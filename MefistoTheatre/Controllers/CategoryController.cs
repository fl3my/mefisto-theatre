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
    }
}
