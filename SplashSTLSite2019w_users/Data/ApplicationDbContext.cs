﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SplashSTLSite2019w_users.Models;

namespace SplashSTLSite2019w_users.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Location> Locations { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
