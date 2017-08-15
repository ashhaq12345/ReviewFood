using IdentitySample.Models;
using ReviewFood.Models;
using ReviewFood.Models.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace ReviewFood.DAL
{
    public class RestaurantRepository: CommonRepository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository():base(new ApplicationDbContext())
        {

        }

        public RestaurantRepository(DbContext db): base(db)
        {

        }
    }
}