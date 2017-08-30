using ReviewFood.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ReviewFood.Models;
using IdentitySample.Models;
using System.Data.Entity.Migrations;
using System.Data.Entity;
ashique
namespace ReviewFood.DAL
{
    public class FoodRepository : CommonRepository<Food>, IFoodRepository
    {
        public FoodRepository(): base(new ApplicationDbContext())
        {

        }

        public FoodRepository(DbContext db): base(db)
        {

        }
    }
}