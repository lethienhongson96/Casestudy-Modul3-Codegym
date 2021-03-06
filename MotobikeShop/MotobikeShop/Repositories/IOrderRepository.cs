﻿using MotobikeShop.Models.Entities;
using MotobikeShop.Models.ViewModels;
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

        ConfirmPayView GetConfirmInfo(int id);

        double GetTotalInAOrder(Order order);

        int PayOrder(int id);

        int AddOrderDetailInOrder(Order order,int productId, int amount);

        List<OrderDetail> GetOrderDetailsByOrderId(int id);

        List<Order> GetOrdersByUserId(string id);
    }
}
