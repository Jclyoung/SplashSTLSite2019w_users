﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SplashSTLSite2019w_users.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    //  cd .\SplashSTLSite2019w_users
    //  dotnet ef migrations add "NAME"
    //  dotnet ef database update

}
