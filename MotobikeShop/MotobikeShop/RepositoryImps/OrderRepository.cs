using Microsoft.AspNetCore.Identity;
using MotobikeShop.Models;
using MotobikeShop.Models.Entities;
using MotobikeShop.Models.ViewModels;
using MotobikeShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.RepositoryImps
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IOrderDetailRepository detailRepository;

        public OrderRepository(AppDbContext context,UserManager<ApplicationUser> userManager,
            IOrderDetailRepository detailRepository)
        {
            this.context = context;
            this.userManager = userManager;
            this.detailRepository = detailRepository;
        }
        public int CreateOrder(Order order)
        {
            context.Add(order);
            return (context.SaveChanges());
        }

        public int CreateOrderDetailInOrder(int id, int amount, string UserId)
        {
            Order order = new Order()
            {
                CreateAt = DateTime.Today,
                CreateBy = UserId,
                ShipperDate = DateTime.Today
            };
            Product product = context.Products.FirstOrDefault(el=>el.Id==id);

            if (CreateOrder(order) > 0)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    OrderId = order.Id,
                    ProductId = id,
                    Quantity = amount,
                    UnitPrice= product.PricePerUnit*amount
                };
                context.Add(orderDetail);

                product.SaleCount += amount;
                context.Update(product);
            }
            return context.SaveChanges();
        }

        public int DeleteOrder(int id)
        {
            var order = context.Orders.FirstOrDefault(el => el.Id == id);

            if (order == null)
                return -1;
            context.Remove(order);

            return context.SaveChanges();
        }

        public ConfirmPayView GetConfirmInfo(int id)
        {
            Order order = context.Orders.FirstOrDefault(el => el.Id == id);

            ConfirmPayView confirmPay = new ConfirmPayView()
            {
                NameCustomer = userManager.FindByIdAsync(order.CreateBy).Result.FullName,
                CreateAt = order.CreateAt.ToString(),
                ShipDate = order.ShipperDate.ToString(),
                Total = GetTotalInAOrder(order)
            };
            return confirmPay;
        }

        public Order GetOrder(int id) => context.Orders.FirstOrDefault(el => el.Id == id);

        public List<Order> GetOrderList() => context.Orders.ToList().FindAll(el => el.PayStatus == Enums.PayStatus.unpaid);

        public double GetTotalInAOrder(Order order)
        {
            var orderDetails = context.OrderDetails.ToList().FindAll(el => el.OrderId == order.Id);

            double total = new double();
            foreach (var item in orderDetails)
            {
                var product = context.Products.FirstOrDefault(el => el.Id == item.ProductId);
                total += detailRepository.CalculateMoney(product.PricePerUnit, item.Discount, item.Quantity);
            }
            return total;
        }

        public int PayOrder(int id)
        {
            var order = context.Orders.FirstOrDefault(el => el.Id == id);
            order.PayStatus = Enums.PayStatus.Paid;
            context.Update(order);

            return Task.Run(async () => await context.SaveChangesAsync()).Result;
        }

        public int UpdateOrder(Order order)
        {
            context.Update(order);
            return context.SaveChanges();
        }
    }
}
