﻿using MotobikeShop.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double PricePerUnit { get; set; }
        public DateTime CreateAt { get; set; }
        public string ImagePath { get; set; }
        public Status Status { get; set; }
        public int SaleCount { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string CreateBy { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
