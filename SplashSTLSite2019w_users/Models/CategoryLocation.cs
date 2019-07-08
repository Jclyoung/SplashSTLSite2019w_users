using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplashSTLSite2019w_users.Models
{
    public class CategoryLocation
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual Location Location { get; set; }
    }
}
