using MefistoTheatre.Models;
using MefistoTheatre.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Signing;
using System.Security.Claims;

namespace MefistoTheatre.Controllers
{
    [Authorize(Roles = "Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        // Use dependancy injection to get a instance of user and role manager classes.
        public UserController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IActionResult> Index(string userRole, string searchString)
        {
            // Get list of users from the database asynchronously.
            var users = await _userManager.Users.ToListAsync();

            var roles = _roleManager.Roles;

            // Create a view model.
            var usersViewModel = new List<UserViewModel>();

            // Create a user view model for each user.
            foreach(ApplicationUser user in users)
            {
                string fullname = user.FirstName + " " + user.LastName;

                string? role = await GetUserRole(user);
                string? roleColour = GetBootstrapColourForRole(role);

                var viewModel = new UserViewModel
                {
                    UserId = user.Id,
                    FullName = fullname,
                    Email = user.Email,
                    Role = await GetUserRole(user),
                    RoleColour = roleColour,
                    IsSuspended = user.IsSuspended,
                };

                usersViewModel.Add(viewModel);
            }

            // Check if the user has apsplied a search.
            if (!String.IsNullOrEmpty(searchString))
            {
                // Return all models that have the search string in the email and ignore case.
                usersViewModel = usersViewModel
                    .Where(s => s.FullName!.Contains(searchString, StringComparison.InvariantCultureIgnoreCase))
                    .ToList();
            }

            // Check if the user role filter is not null.
            if (!String.IsNullOrEmpty(userRole))
            {
                // Return all users in the role.
                usersViewModel = usersViewModel.Where(r => r.Role == userRole).ToList();
            }

            var userSearchViewModel = new UserSearchViewModel
            {
                Roles = new SelectList(roles),
                Users = usersViewModel
            };

            return View(userSearchViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var user = await _userManager.FindByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            var viewModel = new UserEditViewModel
            {
                UserId = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                DateOfBirth = user.DateOfBirth,
                Email = user.Email,
                Role = await GetUserRole(user),
                IsSuspended = user.IsSuspended,
                Joined = user.Joined,
                Roles = new SelectList(_roleManager.Roles)
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(UserEditViewModel editViewModel)
        {
            editViewModel.Roles = new SelectList(_roleManager.Roles);

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Failed to edit profile");
                return View("Edit", editViewModel);
            }
          
            // Get the user to be edited.
            var user = await _userManager.FindByIdAsync(editViewModel.UserId);

            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Edit the users role
            var role = await GetUserRole(user);

            // Prevent the admin from changing their own role.
            if (user.Id == currentUserId)
            {
                ModelState.AddModelError("Role", "Cannot Change your own role.");
                return View("Edit", editViewModel);
            }

            if (role != null)
            {
                // Remove the user from the role.
                await _userManager.RemoveFromRoleAsync(user, role);
            }

            // Add the new role to the user.
            await _userManager.AddToRoleAsync(user, editViewModel.Role);

            // Edit other properties.
            user.FirstName = editViewModel.FirstName;
            user.LastName = editViewModel.LastName;
            user.DateOfBirth = editViewModel.DateOfBirth;
            user.IsSuspended = editViewModel.IsSuspended;
            
            await _userManager.UpdateAsync(user);

            return RedirectToAction("Index");
        }

        private static string GetBootstrapColourForRole(string? role)
        {
            if (role == null)
            {
                return "bg-primary";
            }

            // Use a dictionary lookup to get the colour for a role.
            var colourDict = new Dictionary<string, string>
            {
                ["Admin"] = "bg-success",
                ["Editor"] = "bg-info",
                ["Basic"] = "bg-primary",
                ["Staff"] = "bg-warning"
            };

            return colourDict[role];
        }

        private async Task<string?> GetUserRole(ApplicationUser user)
        {
            // Return the first role in the roles list or null if empty.
            var roles = await _userManager.GetRolesAsync(user);
            return roles.ToList().FirstOrDefault();
        }
    }
}
