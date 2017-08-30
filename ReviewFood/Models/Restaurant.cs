using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewFood.Models
{
    public class Restaurant
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}