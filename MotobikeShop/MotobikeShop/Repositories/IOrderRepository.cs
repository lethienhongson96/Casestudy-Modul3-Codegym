using MotobikeShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.Repositories
{
    public interface IOrderRepository
    {
        int CreateOrder(Order order);

        List<Order> GetOrderList();

        int DeleteOrder(int id);

        Order GetOrder(int id);

        int UpdateOrder(Order order);
    }
}
