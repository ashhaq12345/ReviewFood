using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewFood.Models
{
    public class Restaurant
    {
        [Required]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Food> Foods { get; set; }
    }
}