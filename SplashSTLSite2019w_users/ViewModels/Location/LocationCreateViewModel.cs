using SplashSTLSite2019w_users.Data;
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

        public LocationCreateViewModel() { }


        public void CreateLocation(ApplicationDbContext context, LocationCreateViewModel createModel)
        {
            Models.Location location = new Models.Location();
            {
                location.Name = createModel.Name;
                location.Description = createModel.Description;
                location.Address = createModel.Address;
                location.Region = createModel.Region;
            }
            context.Locations.Add(location);
            context.SaveChanges();
        }
    }
}
