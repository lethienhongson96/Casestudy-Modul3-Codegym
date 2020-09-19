using Microsoft.AspNetCore.Identity;
using MotobikeShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public string Avatar { get; set; }
        

        public ICollection<Order> Orders { get; set; }

        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        
    }
}
