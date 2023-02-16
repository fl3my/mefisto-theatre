using MefistoTheatre.Data;
using MefistoTheatre.Enums;
using MefistoTheatre.Models;
using MefistoTheatre.ViewModels.Post;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace MefistoTheatre.Controllers
{
    [Authorize(Roles = "Staff, Editor, Admin")]
    public class PostController : Controller
    {
        // Create a instance of the database.
        private readonly ApplicationDbContext _dbContext;
        private readonly UserManager<ApplicationUser> _userManager;

        public PostController(ApplicationDbContext dbContext, UserManager<ApplicationUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }

        // GET: PostController
        public async Task<IActionResult> Index()
        {
            // Get the current user id.
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (currentUserId == null)
            {
                return NotFound();
            }

            // Get all the posts that belong to the current user.
            var userPosts = await _dbContext.Posts
                .Where(p => p.AuthorId == currentUserId)
                .OrderByDescending(p => p.UpdatedDate)
                .ToListAsync();

            // Create a list to store all the values in the viewModel.
            var PostViewModels = new List<PostViewModel>();

            foreach (var userPost in userPosts)
            {
                var viewModel = new PostViewModel
                {
                    PostId = userPost.PostId,
                    Title = userPost.Title,
                    Summary = userPost.Summary,
                    Status = userPost.Status,
                    CreatedDate = userPost.CreatedDate
                };

                PostViewModels.Add(viewModel);
            }

            return View(PostViewModels);
        }

        // GET: PostController/Create
        public async Task<IActionResult> Create()
        {
            IEnumerable<Category> categoryList = await _dbContext.Categories.ToListAsync();

            var viewModel = new PostCreateViewModel()
            {
                Categories = categoryList
            };
            return View(viewModel);
        }

        // POST: PostController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string buttonValue, PostCreateViewModel viewModel)
        {
            // Check if the model state is valid.
            if (!ModelState.IsValid)
            {
                IEnumerable<Category> categoryList = await _dbContext.Categories.ToListAsync();
                viewModel.Categories = categoryList;
                return View(viewModel);
            }

            // Get the current user.
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Bind the viewmodel to the domain model.
            Post post = new()
            {
                Title = viewModel.Title,
                Summary = viewModel.Summary,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Status = PostStatus.Draft,
                Content = viewModel.Content,
                CategoryId = viewModel.CategoryId,
                AuthorId = currentUserId,
            };

            // If the review button is selected mark the post as to be reviewed.
            if (buttonValue == "review")
                post.Status = PostStatus.ToBeReviewed;

            // Add the Post to the database.
            await _dbContext.AddAsync(post);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // GET: PostController/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            var post = await _dbContext.Posts.FindAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            // If the post is in review or published, redirect the user as only editors and admins can edit review posts.
            if (post.Status != PostStatus.Draft)
            {
                if (User.IsInRole("Staff"))
                {
                    return RedirectToAction("Preview", new { id = post.PostId });
                }
            }

            // Get the possible categories.
            IEnumerable<Category> categoryList = await _dbContext.Categories.ToListAsync();

            // Store the current users status options to be displayed in a list.
            var postStatusList = new List<PostStatus>
            {
                PostStatus.Draft,
                PostStatus.ToBeReviewed,
            };

            // If user is not a staff member ( so admin or editor) then add the pubish option.
            if (!User.IsInRole("Staff"))
            {
                postStatusList.Add(PostStatus.Published);
            }

            // Create the select list.
            var statusSelect = new SelectList(postStatusList);

            // Bind the post data to the viewModel.
            var viewModel = new PostEditViewModel()
            {
                PostId = post.PostId,
                Title = post.Title,
                Summary = post.Summary,
                CreatedDate = post.CreatedDate,
                UpdatedDate = post.UpdatedDate,
                Status = post.Status,
                StatusSelect = statusSelect,
                Content = post.Content,
                CategoryId = post.CategoryId,
                Categories = categoryList
            };

            return View(viewModel);
        }

        // POST: PostController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, string buttonValue, PostEditViewModel viewModel)
        {
            // Get the current user.
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var post = await _dbContext.Posts.FindAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            // Prevent a Staff member from changing the post status.
            if (User.IsInRole("Staff") && post.Status != PostStatus.Draft) {
                if (viewModel.Status != post.Status)
                {
                    ModelState.AddModelError("", "Sorry only an editor or and admin can edit a post once sent to review or published.");
                }
            }

            // Check if the form input meets the validation.
            if (!ModelState.IsValid)
            {
                IEnumerable<Category> categoryList = await _dbContext.Categories.ToListAsync();

                var postStatusList = new List<PostStatus>
                {
                    PostStatus.Draft,
                    PostStatus.ToBeReviewed,
                };

                if (!User.IsInRole("Staff"))
                {
                    postStatusList.Add(PostStatus.Published);
                }

                var statusSelect = new SelectList(postStatusList);

                viewModel.CreatedDate = post.CreatedDate;
                viewModel.UpdatedDate = post.UpdatedDate;
                viewModel.Status = post.Status;
                viewModel.StatusSelect = statusSelect;
                viewModel.PublishedAt = post.PublishedAt;
                viewModel.Categories = categoryList;

                return View(viewModel);
            }

            // When post is published save the time.
            if (viewModel.Status == PostStatus.Published)
            {
                post.PublishedAt = DateTime.Now;
            }

            // Append the post object from the database.
            post.Title = viewModel.Title;
            post.Summary = viewModel.Summary;
            post.UpdatedDate = DateTime.Now;
            post.Status = viewModel.Status;
            post.Content = viewModel.Content;
            post.CategoryId = viewModel.CategoryId;

            // Update and save changes.
            _dbContext.Posts.Update(post);
            await _dbContext.SaveChangesAsync();

            // if the user selected the preview option, redirect to the preview page.
            if (buttonValue == "preview")
                return RedirectToAction("Preview", new { id = post.PostId });

            // If the user is a staff member
            if(User.IsInRole("Staff") || currentUserId == post.AuthorId) {
                return RedirectToAction("Index");
            }

            // Redirect the user
            return RedirectToAction("Index", "Admin");
        }

        public async Task<IActionResult> Preview(string id)
        {
            // Check if post exists.
            if (id == null)
            {
                return NotFound();
            }
            
            var post = await _dbContext.Posts.FindAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            // Get the user to get the users full name.
            var user = await _userManager.FindByIdAsync(post.AuthorId);
            string authorName = user.FirstName + " " + user.LastName;

            var viewModel = new PostPreviewViewModel()
            {
                Title = post.Title,
                Summary = post.Summary,
                Content = post.Content,
                AuthorName = authorName
            };

            return View(viewModel);
        }

        // GET: PostController/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var post = await _dbContext.Posts.FindAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            // Only allow admins or editors to delete a post.
            if (post.AuthorId != currentUserId)
            {
                if (User.IsInRole("Staff"))
                {
                    return Unauthorized();
                }
            }

            var viewModel = new PostDeleteViewModel()
            {
                PostId = post.PostId,
                Title = post.Title
            };

            return View(viewModel);
        }

        // POST: PostController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            // Check if the posts table has any content.
            if (_dbContext.Posts == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Posts' is null.");
            }

            var post = await _dbContext.Posts.FindAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            // Remove the post from the database context and sav changes.
            _dbContext.Posts.Remove(post);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
