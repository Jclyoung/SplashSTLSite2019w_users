using Microsoft.EntityFrameworkCore;
using SplashSTLSite2019w_users.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplashSTLSite2019w_users.ViewModels.Location
{
    public class LocationListItemViewModel
    {
        private ApplicationDbContext context;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Models.LocationRating> LocationRatings { get; set; }
        public string AverageRating { get; set; }


        public static List<LocationListItemViewModel> GetLocations(ApplicationDbContext context)
        {
            List<Models.Location> locations = context.Locations
                .Include(l => l.LocationRatings)
                .ToList();

            List<LocationListItemViewModel> vMLocations = new List<LocationListItemViewModel>();
            foreach (Models.Location location in locations)
            {
                LocationListItemViewModel lLModel = new LocationListItemViewModel();
                lLModel.Id = location.Id;
                lLModel.Name = location.Name;
                lLModel.Description = location.Description;
                lLModel.LocationRatings = location.LocationRatings;
                lLModel.AverageRating = location.LocationRatings.Count > 0 ? 
                    Math.Round(location.LocationRatings.Average(x => x.Rating), 2)
                    .ToString() : "No Ratings";

                vMLocations.Add(lLModel);
            }
            return vMLocations;
        }
    }
}
