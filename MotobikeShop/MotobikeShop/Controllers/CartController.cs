using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MotobikeShop.Models;
using MotobikeShop.Models.CartSession;
using MotobikeShop.Models.Entities;
using MotobikeShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MotobikeShop.Controllers
{
    [AllowAnonymous]
    public class CartController : Controller
    {
        public CartController(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            this.orderRepository = orderRepository;
            this.productRepository = productRepository;
        }
        private const string CartSession = "CartSession";
        private readonly IOrderRepository orderRepository;
        private readonly IProductRepository productRepository;

        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSession);
            HttpContext.Session.SetObjectAsJson(CartSession, cart);

            return View(cart);
        }

        [Route("/Cart/AddItem/{id}/{amount}")]
        public IActionResult AddItem(int id, int amount)
        {
            CartItem item = new CartItem() { ProductId = id, Amount = amount };
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSession);

            if (cart.Count != 0)
            {
                if (cart.Exists(el => el.ProductId == item.ProductId))
                {
                    cart.FirstOrDefault(el => el.ProductId == item.ProductId).Amount += amount;
                    HttpContext.Session.SetObjectAsJson(CartSession, cart);
                    return Json(-1);
                }
                else
                {
                    cart.Add(item);
                    HttpContext.Session.SetObjectAsJson(CartSession, cart);
                    return Json(cart.Count);
                }
            }
            cart.Add(item);
            HttpContext.Session.SetObjectAsJson(CartSession, cart);

            return Json(cart.Count);
        }

        [Route("/Cart/OrderByAccount/{id}")]
        public IActionResult OrderByAccount(string id)
        {
            var order = new Order()
            {
                CreateBy = id,
                CreateAt=DateTime.Today,
                ShipperDate= DateTime.Today
            };
            orderRepository.CreateOrder(order);

            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSession);
            foreach (var item in cart)
                orderRepository.AddOrderDetailInOrder(order, item.ProductId, item.Amount);
            int result = orderRepository.GetOrderDetailsByOrderId(order.Id).Count;

            if(result>0)
                HttpContext.Session.SetObjectAsJson(CartSession, new List<CartItem>());

            return Json(result);
        }
    }
}
