using SplashSTLSite2019w_users.Data;
using System.Collections.Generic;
using System.Linq;
using SplashSTLSite2019w_users.ViewModels.LocationRating;
using Microsoft.EntityFrameworkCore;

namespace SplashSTLSite2019w_users.ViewModels.Location
{
    public class LocationDetailsViewModel
    {
        private ApplicationDbContext context;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<LocationRatingDetailsViewModel> RatingDetailModels { get; set; }
        public List<Models.LocationRating> Reviews { get; set; }

        public static LocationDetailsViewModel GetLocationDetailsViewModel(ApplicationDbContext context, int id)
        {
            Models.Location location = context.Locations                
                .Single(l => l.Id == id);

            List<Models.LocationRating> locationRatings = context.LocationRatings
                .Where(r => r.LocationId == id)
                .ToList();

            List<LocationRatingDetailsViewModel> ratingDetailsmodels = new List<LocationRatingDetailsViewModel>();

            foreach (Models.LocationRating locationRating in locationRatings)
            {
                LocationRatingDetailsViewModel ratingDetailsModel = new LocationRatingDetailsViewModel();
                ratingDetailsModel.Rating = locationRating.Rating;
                ratingDetailsModel.Review = locationRating.Review;
                ratingDetailsmodels.Add(ratingDetailsModel);

            }


            LocationDetailsViewModel lDModel = new LocationDetailsViewModel();
            lDModel.RatingDetailModels = ratingDetailsmodels;
            lDModel.Name = location.Name;
            lDModel.Description = location.Description;
            lDModel.Id = location.Id;

            lDModel.RatingDetailModels = ratingDetailsmodels;
            return lDModel;
        }

    }
}
