﻿using MefistoTheatre.Data;
using MefistoTheatre.Models;
using MefistoTheatre.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;

namespace MefistoTheatre.Controllers
{
    [Authorize(Roles = "Staff, Editor, Admin")]
    public class PostController : Controller
    {
        // Create a instance of the database.
        private readonly ApplicationDbContext _dbContext;

        public PostController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
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
            var userPosts = await _dbContext.Posts.Where(p => p.AuthorId == currentUserId).ToListAsync();
            
            // Create a list to store all the values in the viewModel.
            var PostViewModels = new List<PostViewModel>();

            foreach(var userPost in userPosts)
            {
                var viewModel = new PostViewModel
                {
                    Title = userPost.Title,
                    Summary = userPost.Summary,
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
            Post post = new Post()
            {
                Title = viewModel.Title,
                Summary = viewModel.Summary,
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now,
                Published = false,
                Content = viewModel.Content,
                CategoryId = viewModel.CategoryId,
                AuthorId = currentUserId,
            };

            if (buttonValue == "save")
                post.ToBeReviewed = false;

            if (buttonValue == "publish")
                post.ToBeReviewed = true;

            // Add the Post to the database.
            await _dbContext.AddAsync(post);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // GET: PostController/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var post = await _dbContext.Posts.Where(p => p.PostId == id).FirstOrDefaultAsync();

            if (post == null)
            {
                return NotFound();
            }

            // Check if the post belongs to the user.
            if (currentUserId != post.AuthorId)
            {
                return NotFound();
            }

            // Get the possible categories.
            IEnumerable<Category> categoryList = await _dbContext.Categories.ToListAsync();

            // Bind the post data to the viewModel.
            var viewModel = new PostEditViewModel()
            {
                Title = post.Title,
                Summary = post.Summary,
                CreatedDate = post.CreatedDate,
                UpdatedDate = post.UpdatedDate,
                Published = post.Published,
                ToBeReviewed = post.ToBeReviewed,
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
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var post = await _dbContext.Posts.Where(p => p.PostId == id).FirstOrDefaultAsync();

            if (post == null)
            {
                return NotFound();
            }

            // Check if the post belongs to the user.
            if (currentUserId != post.AuthorId)
            {
                return NotFound();
            }

            if (buttonValue == "save")
                post.ToBeReviewed = false;

            if (buttonValue == "publish")
                post.ToBeReviewed = true;

            post.Title = viewModel.Title;
            post.Summary = viewModel.Summary;
            post.UpdatedDate = DateTime.Now;
            post.Content = viewModel.Content;
            post.CategoryId = viewModel.CategoryId;

            _dbContext.Posts.Update(post);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        // GET: PostController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PostController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
