using IdentitySample.Models;
using ReviewFood.Models;
using ReviewFood.Models.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ReviewFood.DAL
{
    public class ReviewRepository: CommonRepository<Review>, IReviewRepository
    {
        public ReviewRepository(): base(new ApplicationDbContext())
        {

        }

        public ReviewRepository(DbContext db): base(db)
        {

        }
    }
}