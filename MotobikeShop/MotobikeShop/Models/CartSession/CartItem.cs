﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.Models
{
    [Serializable]
    public class CartItem
    {
        public int ProductId { get; set; }
        public int Amount { get; set; }
    }
}
