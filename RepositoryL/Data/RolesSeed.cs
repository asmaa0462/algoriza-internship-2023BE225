using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryL.Data
{
    public static class RolesSeed
    {
        public static void rolesseed(this ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Name="Admin"},
                new IdentityRole() { Name = "Doctor"},
                new IdentityRole() { Name = "Patient" }
                );
        }
    }
}
