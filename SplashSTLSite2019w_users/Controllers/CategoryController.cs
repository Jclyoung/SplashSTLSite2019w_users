using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SplashSTLSite2019w_users.Data;
using SplashSTLSite2019w_users.Models;
using SplashSTLSite2019w_users.ViewModels;
using SplashSTLSite2019w_users.ViewModels.Category;

namespace SplashSTLSite2019w_users.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext context;

        public CategoryController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Category> categories = context.Categories.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CategoryCreateViewModel categoryCreateViewModel)
        {
            int id = CategoryCreateViewModel.CreateCategory(context, categoryCreateViewModel);
            return RedirectToAction("Index", "Location");

        }
    }
}