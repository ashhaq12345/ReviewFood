using IdentitySample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewFood.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public Food Food { get; set; }
        public int FoodId { get; set; }
        public virtual ApplicationUser User{ get; set; }
        public virtual string UserId { get; set; }
    }
}