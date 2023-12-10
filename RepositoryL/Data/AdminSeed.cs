using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryL.Data
{
    public static class AdminSeed
    {

        public static void adminseed(this ModelBuilder modelbuilder)
        {
            string email = "admin@admin.com";
            string password = "Test02#8";
            var user = new IdentityUser();
            user.UserName = email;
            user.Email = email;

            modelbuilder.Entity<IdentityRole>().HasData(user);
        }
    }
}
