using MefistoTheatre.Data;
using MefistoTheatre.Enums;
using MefistoTheatre.Models;
using MefistoTheatre.ViewModels.Admin;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MefistoTheatre.Controllers
{
    [Authorize(Roles = "Admin, Editor")]
    public class AdminController : Controller
    {
        // Create a instance of the database.
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        // GET: PostController
        public ActionResult Index()
        {
            int totalPublishedPosts = _dbContext.Posts.Where(s => s.Status == PostStatus.ToBeReviewed).Count();

            var viewModel = new AdminDashboardViewModel
            {
                PublishedPostCount = totalPublishedPosts
            };

            // Show the user how many post have to be reviewed and publised.
            return View(viewModel);
        }

        public async Task<IActionResult> AllPosts(PostStatus? postStatus, string searchString)
        {

            // Get all the posts that belong to the current user.
            var userPosts = await _dbContext.Posts.ToListAsync();

            // Create a list to store all the values in the viewModel.
            var adminViewModel = new List<AdminViewModel>();

            foreach (var userPost in userPosts)
            {
                var user = await _userManager.FindByIdAsync(userPost.AuthorId);
                string authorFullName = user.FirstName + " " + user.LastName;

                var viewModel = new AdminViewModel
                {
                    Title = userPost.Title,
                    AuthorName = authorFullName,
                    CreatedDate = userPost.CreatedDate,
                    Status = userPost.Status,
                };

                adminViewModel.Add(viewModel);
            }

            // Check if the user has apsplied a search.
            if (!String.IsNullOrEmpty(searchString))
            {
                // Return all models that have the search string in the title and ignore case.
                adminViewModel = adminViewModel
                    .Where(s => s.Title!.Contains(searchString, StringComparison.InvariantCultureIgnoreCase))
                    .OrderByDescending(d => d.CreatedDate)
                    .ToList();
            }

            if (postStatus != null)
            {
                adminViewModel = adminViewModel.Where(s => s.Status == postStatus)
                    .OrderByDescending(d => d.CreatedDate)
                    .ToList();
            }

            var adminSearchViewModel = new AdminSearchViewModel
            {
                Posts = adminViewModel,
                Status = postStatus,
                SearchString = searchString
            };

            return View(adminSearchViewModel);
        }
    }
}
