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
        [Required(ErrorMessage = "Description must be between 2 and 200 characters.")]
        [MinLength(2)]
        [MaxLength(200)]
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


        public void CreateLocation(ApplicationDbContext context, LocationCreateViewModel locationViewModel)
        {
            Models.Location location = new Models.Location();
            {
                location.Name = locationViewModel.Name;
                location.Description = locationViewModel.Description;
                location.Address = locationViewModel.Address;
                location.Region = locationViewModel.Region;
            }
           
            context.Locations.Add(location);
            List<Models.CategoryLocation> categoryLocations = CreateCategoryLocationRelationships(location.Id);
            location.CategoryLocations = categoryLocations;
            context.SaveChanges();


        }
        
        private List<Models.CategoryLocation> CreateCategoryLocationRelationships(int locationId)
        {
            return CategoryIds.Select(categoryId => new Models.CategoryLocation { LocationId = locationId, CategoryId = categoryId }).ToList();
        }

    }
}