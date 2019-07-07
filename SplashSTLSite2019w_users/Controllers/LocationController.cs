using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SplashSTLSite2019w_users.Data;
using SplashSTLSite2019w_users.Models;

namespace SplashSTLSite2019w_users.Controllers
{
    public class LocationController : Controller
    {
        private ApplicationDbContext context;
        public LocationController(ApplicationDbContext context)
        {
            this.context = context;

        }
        public IActionResult Index()
        {
            List<Location> locations = context.Locations.ToList();
           return View(locations);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();



        }

        [HttpPost]
        public IActionResult Create(Location location)
        {
            context.Add(location);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

    }
}