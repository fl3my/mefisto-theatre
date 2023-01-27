using MefistoTheatre.Data;
using MefistoTheatre.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            if(ModelState.IsValid)
            {
                await _dbContext.AddAsync(category);
                await _dbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(category);
        }
    }
}
