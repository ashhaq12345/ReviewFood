﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewFood.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public List<Review> Reviews { get; set; }
    }
}