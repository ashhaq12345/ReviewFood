using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewFood.Models
{
    public class Food
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public long RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public List<Review> Reviews { get; set; }
    }
}