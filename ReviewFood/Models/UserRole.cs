using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReviewFood.Models
{
    public class UserRole
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long RoleId { get; set; }
    }
}