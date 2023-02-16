using MefistoTheatre.Data;
using MefistoTheatre.Enums;
using MefistoTheatre.Models;
using MefistoTheatre.ViewModels.Admin;
using MefistoTheatre.ViewModels.Blog;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

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

        public async Task<IActionResult> Index(string searchTitle, string searchAuthor)
        {
            // Get all published posts from the database.
            var posts = await _dbContext.Posts
                .Where(s => s.Status == PostStatus.Published)
                .Include(c => c.Comments)
                .OrderByDescending(p => p.PublishedAt)
                .ToListAsync();

            var blogsViewModel = new List<BlogViewModel>();

            // Append the values from the database into a viewModel.
            foreach (Post post in posts)
            {
                // Get the user to get the users full name.
                var user = await _userManager.FindByIdAsync(post.AuthorId);
                string authorName = user.FirstName + " " + user.LastName;

                var viewModel = new BlogViewModel()
                {
                    PostId = post.PostId,
                    Title = post.Title,
                    Summary = post.Summary,
                    PublishedAt = post.PublishedAt,
                    CommentCount = post.Comments!.Count,
                    AuthorName = authorName
                };

                blogsViewModel.Add(viewModel);
            }

            // Check if the user has applied a title search.
            if (!String.IsNullOrEmpty(searchTitle))
            {
                // Return all models that have the search string in the title and ignore case.
                blogsViewModel = blogsViewModel
                    .Where(s => s.Title!.Contains(searchTitle, StringComparison.InvariantCultureIgnoreCase))
                    .OrderByDescending(d => d.PublishedAt)
                    .ToList();
            }

            // Check if the user has applied an author search.
            if (!String.IsNullOrEmpty(searchAuthor))
            {
                // Return all models that have the search string in the author and ignore case.
                blogsViewModel = blogsViewModel
                    .Where(s => s.AuthorName!.Contains(searchAuthor, StringComparison.InvariantCultureIgnoreCase))
                    .OrderByDescending(d => d.PublishedAt)
                    .ToList();
            }

            var blogSearchViewModel = new BlogSearchViewModel()
            {
                Posts = blogsViewModel,
                SearchTitle = searchTitle,
                SearchAuthor = searchAuthor
            };

            return View(blogSearchViewModel);
        }

        public async Task<IActionResult> Details(string id)
        {
            // Get all published posts from the database.
            var post = await _dbContext.Posts
                .Include(p => p.Comments)
                .FirstOrDefaultAsync(p => p.PostId == id);

            if (post == null)
            {
                return NotFound();
            }

            // Get the user to get the users full name.
            var user = await _userManager.FindByIdAsync(post.AuthorId);
            string authorName = user.FirstName + " " + user.LastName;

            // Create a comment view model so the authors name can be shown.
            var commentsViewModel = new List<BlogCommentViewModel>();

            // Check if comments exist.
            if(post.Comments != null)
            {
                foreach (var comment in post.Comments)
                {
                    // Find the comment Authors name.
                    var commentUser = await _userManager.FindByIdAsync(comment.AuthorId);
                    string commentAuthor = commentUser.FirstName + " " + commentUser.LastName;

                    // Create an individual view Model.
                    var commentViewModel = new BlogCommentViewModel()
                    {
                        CommentId = comment.CommentId,
                        AuthorName = commentAuthor,
                        AuthorId = commentUser.Id,
                        PublishedAt = comment.PublishedAt,
                        Content = comment.Content,
                    };

                    // Add to the new List.
                    commentsViewModel.Add(commentViewModel);
                }
            }

            // reorder comments viewmodel.
            commentsViewModel = commentsViewModel.OrderBy(c => c.PublishedAt).ToList();

            var viewModel = new BlogDetailsViewModel()
            {
                PostId = post.PostId,
                Title = post.Title,
                Content = post.Content,
                PublishedAt = post.PublishedAt,
                AuthorName = authorName,
                Comments = commentsViewModel
            };

            return View(viewModel);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CreateComment(BlogDetailsViewModel viewModel)
        {
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var currentUser = await _userManager.FindByIdAsync(currentUserId);

            if(currentUser.IsSuspended)
            {
                ModelState.AddModelError("NewCommentContent", "Sorry you are unable to comment as you have been suspended.");
            }

            if (!ModelState.IsValid)
            {
                // Get all published posts from the database.
                var post = await _dbContext.Posts
                    .Include(p => p.Comments)
                    .FirstOrDefaultAsync(p => p.PostId == viewModel.PostId);

                if (post == null)
                {
                    return NotFound();
                }

                // Get the user to get the users full name.
                var user = await _userManager.FindByIdAsync(post.AuthorId);
                string authorName = user.FirstName + " " + user.LastName;

                // Create a comment view model so the authors name can be shown.
                var commentsViewModel = new List<BlogCommentViewModel>();

                // Check if comments exist.
                if (post.Comments != null)
                {
                    foreach (var comment in post.Comments)
                    {
                        // Find the comment Authors name.
                        var commentUser = await _userManager.FindByIdAsync(comment.AuthorId);
                        string commentAuthor = commentUser.FirstName + " " + commentUser.LastName;

                        // Create an individual view Model.
                        var commentViewModel = new BlogCommentViewModel()
                        {
                            CommentId = comment.AuthorId,
                            AuthorName = commentAuthor,
                            PublishedAt = comment.PublishedAt,
                            Content = comment.Content,
                        };

                        // Add to the new List.
                        commentsViewModel.Add(commentViewModel);
                    }
                }
                
                
                // reorder comments viewmodel.
                commentsViewModel = commentsViewModel.OrderBy(c => c.PublishedAt).ToList();

                viewModel = new BlogDetailsViewModel()
                {
                    PostId = post.PostId,
                    Title = post.Title,
                    Content = post.Content,
                    PublishedAt = post.PublishedAt,
                    AuthorName = authorName,
                    Comments = commentsViewModel
                };
                return View("Details", viewModel);
            }

            Comment newComment = new Comment
            {
                CreatedDate = DateTime.Now,
                PublishedAt = DateTime.Now,
                Published = true,
                Content = viewModel.NewCommentContent,
                PostId = viewModel.PostId,
                AuthorId = currentUserId
            };

            await _dbContext.AddAsync(newComment);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Details", new {id = viewModel.PostId});
        }

        [HttpPost]
        public async Task<IActionResult> DeleteComment(string? id)
        {
            // Check if the posts table has any content.
            if (_dbContext.Comments == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Comments' is null.");
            }

            var comment = await _dbContext.Comments.FindAsync(id);

            if (comment == null)
            {
                return NotFound();
            }

            // Remove the post from the database context and sav changes.
            _dbContext.Comments.Remove(comment);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }


    }
}
