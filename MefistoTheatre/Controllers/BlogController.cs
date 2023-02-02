using MefistoTheatre.Data;
using MefistoTheatre.Enums;
using MefistoTheatre.Models;
using MefistoTheatre.ViewModels.Blog;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MefistoTheatre.Controllers
{
    public class BlogController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public BlogController(UserManager<ApplicationUser> userManager, ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var posts = await _dbContext.Posts
                .Where(s => s.Status == PostStatus.Published)
                .ToListAsync();

            var homeViewModel = new List<BlogViewModel>();

            foreach (Post post in posts)
            {
                // Get the user to get the users full name.
                var user = await _userManager.FindByIdAsync(post.AuthorId);
                string authorName = user.FirstName + " " + user.LastName;

                var viewModel = new BlogViewModel()
                {
                    Title = post.Title,
                    Summary = post.Summary,
                    PublishedAt = post.PublishedAt,
                    AuthorName = authorName
                };

                homeViewModel.Add(viewModel);
            }

            return View(homeViewModel);
        }

        public async Task<IActionResult> Details(string id)
        {
            return View();
        }
    }
}
