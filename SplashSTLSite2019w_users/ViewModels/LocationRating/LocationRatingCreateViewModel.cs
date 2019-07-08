using SplashSTLSite2019w_users.Data;
using SplashSTLSite2019w_users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplashSTLSite2019w_users.ViewModels.LocationRating
{
    public class LocationRatingCreateViewModel
    {
        private ApplicationDbContext context;

        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }

        public static int GetLocationRatingViewModel(ApplicationDbContext context, LocationRatingCreateViewModel lRCreateViewModel)
        {
            Models.LocationRating locationRating = new Models.LocationRating();
            locationRating.LocationId = lRCreateViewModel.LocationId;
            locationRating.Rating = lRCreateViewModel.Rating;
            locationRating.Review = lRCreateViewModel.Review;
            context.Add(locationRating);
            context.SaveChanges();
            return locationRating.Id;
        }
    }
}
