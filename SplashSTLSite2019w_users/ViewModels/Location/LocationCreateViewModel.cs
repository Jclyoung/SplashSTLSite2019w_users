using SplashSTLSite2019w_users.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplashSTLSite2019w_users.ViewModels.Location
{
    public class LocationCreateViewModel
    {
        private ApplicationDbContext context;

        public string Name { get; set; }
        public string Description { get; set; }
        
        public LocationCreateViewModel() { }


        public void CreateLocation(ApplicationDbContext context, LocationCreateViewModel createModel)
        {
            Models.Location location = new Models.Location();
            {
                location.Name = createModel.Name;
                location.Description = createModel.Description;          
            }
            context.Locations.Add(location);
            context.SaveChanges();
        }
    }
}
