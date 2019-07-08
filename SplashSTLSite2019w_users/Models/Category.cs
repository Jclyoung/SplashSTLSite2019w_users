using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplashSTLSite2019w_users.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryLocation> CategoryLocations { get; set; }

    }
}
