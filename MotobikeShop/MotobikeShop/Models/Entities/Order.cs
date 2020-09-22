using MotobikeShop.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.Models.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public PayStatus PayStatus { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime ShipperDate { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public string CreateBy { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int InfoCustomerId { get; set; }
        public InfoCustomer InfoCustomer{ get; set; }

    }
}
