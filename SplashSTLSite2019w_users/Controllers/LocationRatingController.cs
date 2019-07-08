using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SplashSTLSite2019w_users.Data;
using SplashSTLSite2019w_users.Models;
using SplashSTLSite2019w_users.ViewModels.LocationRating;

namespace SplashSTLSite2019w_users.Controllers
{
    public class LocationRatingController : Controller
    {
        private ApplicationDbContext context;

        public LocationRatingController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create(int locationId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(LocationRatingCreateViewModel locationRatingCreateViewModel)
        {
            int Id = LocationRatingCreateViewModel.GetLocationRatingViewModel(context, locationRatingCreateViewModel);

            return RedirectToAction(controllerName: nameof(Location), actionName: nameof(Index));
        }
    }
}