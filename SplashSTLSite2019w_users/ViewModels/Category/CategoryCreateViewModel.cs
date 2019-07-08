using SplashSTLSite2019w_users.Data;
using SplashSTLSite2019w_users.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SplashSTLSite2019w_users.ViewModels.Category
{
    public class CategoryCreateViewModel
    {
        private ApplicationDbContext context;

        public int Id { get; set; }

        public string Name { get; set; }

        public static int CreateCategory(ApplicationDbContext context, CategoryCreateViewModel categoryCreateViewModel)
        {
            Models.Category category = new Models.Category();
            {
                category.Name = categoryCreateViewModel.Name;
            }
            context.Add(category);
            context.SaveChanges();

            return category.Id;
        }
    }

}

