using IdentitySample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewFood.Models
{
    public class Review
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public long FoodId { get; set; }
        public string UserId { get; set; }
    }
}