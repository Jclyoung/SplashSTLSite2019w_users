using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SplashSTLSite2019w_users.Data;
using SplashSTLSite2019w_users.Models;
using SplashSTLSite2019w_users.ViewModels;
using SplashSTLSite2019w_users.ViewModels.Category;
using SplashSTLSite2019w_users.ViewModels.Location;
using SplashSTLSite2019w_users.ViewModels.LocationRating;


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
            List<LocationListItemViewModel> listModels = LocationListItemViewModel.GetLocations(context);
            return View(listModels);
        }

        [HttpGet]
        public IActionResult Create()
        {
            LocationCreateViewModel locationViewModel = new LocationCreateViewModel(context);
            return View(locationViewModel);
        }
        [HttpPost]
        public IActionResult Create(LocationCreateViewModel createModel)
        {
            if (!ModelState.IsValid)
            {
                return View(createModel);
            }

            createModel.CreateLocation(context, createModel);

            return RedirectToAction(nameof(Index));

        }

        public IActionResult Details(int id)
        {

            LocationDetailsViewModel detailsModel = LocationDetailsViewModel.GetLocationDetailsViewModel(context, id);
            return View(detailsModel);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return View(model: new LocationEditViewModel(id, context));
        }

        [HttpPost]
        public IActionResult Edit(LocationEditViewModel editModel, int id)
        {
            if (!ModelState.IsValid)
            {
                return View(new LocationEditViewModel());
            }
            editModel.Persist(id, context);
            return RedirectToAction(actionName: nameof(Index));
        }
    }
}