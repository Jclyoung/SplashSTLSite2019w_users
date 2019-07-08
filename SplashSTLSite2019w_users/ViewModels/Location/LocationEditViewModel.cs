using SplashSTLSite2019w_users.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SplashSTLSite2019w_users.ViewModels.Location
{
    public class LocationEditViewModel
    {
        private ApplicationDbContext context;
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is a required field and must be between 2 and 200 characters.")]
        [MaxLength(200)]
        [MinLength(2)]
        public string Description { get; set; }
        public string Address { get; set; }
        [Required]
        public string Region { get; set; }


        public LocationEditViewModel() { }

        public LocationEditViewModel(int id, ApplicationDbContext context)
        {
            Models.Location location = context.Locations.Find(id);
            this.Name = location.Name;
            this.Description = location.Description;
            this.Address = location.Address;
            this.Region = location.Region;
        }
        public void Persist(int id, ApplicationDbContext context)
        {
            Models.Location location = new Models.Location()
            {
                Id = id,
                Name = this.Name,
                Description = this.Description,
                Address = this.Address,
                Region = this.Region,

            };
            context.Update(location);
            context.SaveChanges();
        }
    }
}

