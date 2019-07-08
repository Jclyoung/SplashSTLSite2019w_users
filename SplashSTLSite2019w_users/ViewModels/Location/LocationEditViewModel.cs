using SplashSTLSite2019w_users.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplashSTLSite2019w_users.ViewModels.Location
{
    public class LocationEditViewModel
    {
        private ApplicationDbContext context;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public LocationEditViewModel() { }

        public LocationEditViewModel(int id, ApplicationDbContext context)
        {
            Models.Location location = context.Locations.Find(id);
            this.Name = location.Name;
            this.Description = location.Description;
        }
        public void Persist(int id, ApplicationDbContext context)
        {
            Models.Location location = new Models.Location()
            {
                Id = id,
                Name = this.Name,
                Description = this.Description,
                
            };
            context.Update(location);
            context.SaveChanges();
        }
    }
}

