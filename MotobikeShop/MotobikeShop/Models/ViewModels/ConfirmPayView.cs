using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.Models.ViewModels
{
    public class ConfirmPayView
    {
        public string NameCustomer { get; set; }
        public string CreateAt { get; set; }
        public string ShipDate { get; set; }
        public double Total { get; set; }
    }
}
