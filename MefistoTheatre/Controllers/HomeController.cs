using MefistoTheatre.Data;
using MefistoTheatre.Enums;
using MefistoTheatre.Models;
using MefistoTheatre.ViewModels;
using MefistoTheatre.ViewModels.Post;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;

namespace MefistoTheatre.Controllers
{
    public class HomeController : Controller
    {   
        public IActionResult Index()
        {

            return View();
        }

    }
}