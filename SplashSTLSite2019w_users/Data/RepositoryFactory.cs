using SplashSTLSite2019w_users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplashSTLSite2019w_users.Data
{
    public class RepositoryFactory
    {
        private static ILocationRepository locationRepository;

        public static ILocationRepository GetLocationRepository()
        {
            if (locationRepository == null)
                locationRepository = new LocationRepository();
            return locationRepository;
        }
    }
}
