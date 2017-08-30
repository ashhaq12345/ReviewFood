using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewFood.Models
{
    public class Food
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string FilePath { get; set; }
        public long RestaurantId { get; set; }
    }
}