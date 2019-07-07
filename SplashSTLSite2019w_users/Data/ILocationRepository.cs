using SplashSTLSite2019w_users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplashSTLSite2019w_users.Data
{
    public interface ILocationRepository
    {
        Location GetById(int id);
        List<Location> GetLocations();
        int Save(Location location);
        void Delete(int id);
        void Update(Location location);
    }
}
