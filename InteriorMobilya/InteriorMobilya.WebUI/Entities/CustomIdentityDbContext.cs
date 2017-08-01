﻿using InteriorMobilya.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InteriorMobilya.WebUI.Entities
{
    public class CustomIdentityDbContext : IdentityDbContext<CustomIdentityUser,CustomIdentityRole,Guid>
    {
        
        public CustomIdentityDbContext(DbContextOptions<CustomIdentityDbContext> options):base(options)
        {
           
        }

      

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
          
            /*builder.Entity<CustomIdentityUser>().ToTable("Users")
              .HasMany(x => x.Customers)
              .WithOne()
              .HasForeignKey(x => x.UserID);*/
           
        }
    }
}
