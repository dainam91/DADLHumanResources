using DADLHumanResources.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DADLHumanResources.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // any guid
            
            var ADMIN_ID = new Guid("6D6C7751-92B7-4D32-AC9C-CA9ED043E2DF");
            var ROLE_ID = new Guid("BF5E741C-F4E3-45BC-96DD-B1E925CBF30D");
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = ADMIN_ID,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator Role"

            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser 
            {
                Id = ADMIN_ID,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "tranphandainam@gmail.com",
                NormalizedEmail = "tranphandainam@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                SecurityStamp = string.Empty,
                FirstName = "Tran",
                LastName = "Nam",
                Dob = new DateTime(1991,03,18)
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });
        }
    }
}
