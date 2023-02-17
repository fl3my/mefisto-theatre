using MefistoTheatre.Data;
using MefistoTheatre.Models;
using MefistoTheatre.ViewModels.Post;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace MefistoTheatre.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoryController : Controller
    {
        public readonly ApplicationDbContext _dbContext;

        public CategoryController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Category> categoryList = await _dbContext.Categories.ToListAsync();
            return View(categoryList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                await _dbContext.AddAsync(category);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public async Task<IActionResult> Edit(string id)
        {
            var category = await _dbContext.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, Category categoryModel)
        {
            var category = await _dbContext.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(categoryModel);
            }

            category.CategoryName = categoryModel.CategoryName;
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: PostController/Delete/5
        public async Task<IActionResult> Delete(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _dbContext.Categories.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: PostController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            // Check if the posts table has any content.
            if (_dbContext.Categories == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Categories' is null.");
            }

            var category = await _dbContext.Categories.FindAsync(id);

            if (category== null)
            {
                return NotFound();
            }

            // Remove the post from the database context and sav changes.
            _dbContext.Categories.Remove(category);
            await _dbContext.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }   
}
