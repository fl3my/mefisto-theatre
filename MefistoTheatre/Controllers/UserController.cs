using MefistoTheatre.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

        public async Task<IActionResult> Index()
        {
            // Get list of users from the database asynchronously.
            var users = await _userManager.Users.ToListAsync();

            // Create a view model.
            var usersViewModel = new List<UserViewModel>();

            // Create a user view model for each user.
            foreach(ApplicationUser user in users)
            {
                var viewModel = new UserViewModel
                {
                    UserId = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Role = await GetUserRole(user)
                };
                usersViewModel.Add(viewModel);
            }
            return View(usersViewModel);
        }

        private async Task<string?> GetUserRole(ApplicationUser user)
        {
            // Return the first role in the roles list or null if empty.
            var roles = await _userManager.GetRolesAsync(user);
            return roles.ToList().FirstOrDefault();
        }
    }
}
