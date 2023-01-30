using MefistoTheatre.Data;
using MefistoTheatre.Enums;
using MefistoTheatre.Models;
using MefistoTheatre.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MefistoTheatre.Controllers
{
    public class ReviewPostController : Controller
    {
        // Create a instance of the database.
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public ReviewPostController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        // GET: PostController
        public async Task<IActionResult> Index()
        {
            // Show the user how many post have to be reviewed and publised.
            return View();
        }

        public async Task<IActionResult> ViewAll(PostStatus? postStatus, string searchString)
        {

            // Get all the posts that belong to the current user.
            var userPosts = await _dbContext.Posts.ToListAsync();

            // Create a list to store all the values in the viewModel.
            var reviewPostsViewModel = new List<ReviewPostViewModel>();

            foreach (var userPost in userPosts)
            {
                var user = await _userManager.FindByIdAsync(userPost.AuthorId);
                string authorFullName = user.FirstName + " " + user.LastName;

                var viewModel = new ReviewPostViewModel
                {
                    Title = userPost.Title,
                    AuthorName = authorFullName,
                    CreatedDate = userPost.CreatedDate,
                    Status = userPost.Status,
                };

                reviewPostsViewModel.Add(viewModel);
            }

            // Check if the user has apsplied a search.
            if (!String.IsNullOrEmpty(searchString))
            {
                // Return all models that have the search string in the title and ignore case.
                reviewPostsViewModel = reviewPostsViewModel
                    .Where(s => s.Title!.Contains(searchString, StringComparison.InvariantCultureIgnoreCase))
                    .OrderByDescending(d => d.CreatedDate)
                    .ToList();
            }

            if (postStatus != null)
            {
                reviewPostsViewModel = reviewPostsViewModel.Where(s => s.Status == postStatus)
                    .OrderByDescending(d => d.CreatedDate)
                    .ToList();
            }

            var reviewPostSearchViewModel = new ReviewPostSearchViewModel
            {
                Posts = reviewPostsViewModel,
                Status = postStatus,
                SearchString = searchString
            };

            return View(reviewPostSearchViewModel);
        }
    }
}
