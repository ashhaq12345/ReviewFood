using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ReviewFood.Models.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Review> Reviews { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}