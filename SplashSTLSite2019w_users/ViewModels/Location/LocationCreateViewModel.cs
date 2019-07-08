using SplashSTLSite2019w_users.Data;
using SplashSTLSite2019w_users.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SplashSTLSite2019w_users.ViewModels.Location
{
    public class LocationCreateViewModel
    {
        private ApplicationDbContext context;

        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is a required field and must be between 2 and 200 characters.")]
        [MaxLength(200)]
        [MinLength(2)]
        public string Description { get; set; }
        public string Address { get; set; }
        [Required]
        public string Region { get; set; }
        public List<int> CategoryIds { get; set; }
        public List<Models.Category> Categories { get; set; }

        public LocationCreateViewModel() { }

        public LocationCreateViewModel(ApplicationDbContext context)
        {
            this.Categories = context.Categories.ToList();
        }


        public void CreateLocation(ApplicationDbContext context, LocationCreateViewModel createModel)
        {
            Models.Location location = new Models.Location();
            {
                location.Name = createModel.Name;
                location.Description = createModel.Description;
                location.Address = createModel.Address;
                location.Region = createModel.Region;
            }


            List<Models.CategoryLocation> categoryLocations = CreateCategoryLocation(location.Id);
            location.CategoryLocations = categoryLocations;
            context.Locations.Add(location);
            context.SaveChanges();
        }

        private List<CategoryLocation> CreateCategoryLocation(int id)
        {
            return CategoryIds.Select(categoryId => new Models.CategoryLocation
            { LocationId = id, CategoryId = categoryId }).ToList();
        }
    }
}