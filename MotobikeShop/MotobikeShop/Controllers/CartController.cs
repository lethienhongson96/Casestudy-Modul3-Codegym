using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MotobikeShop.Models;
using MotobikeShop.Models.CartSession;
using MotobikeShop.Models.Entities;
using MotobikeShop.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace MotobikeShop.Controllers
{
    [AllowAnonymous]
    public class CartController : Controller
    {
        public CartController(IOrderRepository orderRepository, IProductRepository productRepository,
            ICustomerInfoRepository infoRepository)
        {
            this.orderRepository = orderRepository;
            this.productRepository = productRepository;
            this.infoRepository = infoRepository;
        }
        private const string CartSession = "CartSession";
        private readonly IOrderRepository orderRepository;
        private readonly IProductRepository productRepository;
        private readonly ICustomerInfoRepository infoRepository;

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
                CreateAt = DateTime.Today,
                ShipperDate = DateTime.Today
            };
            orderRepository.CreateOrder(order);

            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSession);
            foreach (var item in cart)
                orderRepository.AddOrderDetailInOrder(order, item.ProductId, item.Amount);

            int result = orderRepository.GetOrderDetailsByOrderId(order.Id).Count;
            if (result > 0)
                HttpContext.Session.SetObjectAsJson(CartSession, new List<CartItem>());

            return Json(result);
        }

        [Route("/Cart/RemoveItem/{id}")]
        public IActionResult RemoveItem(int id)
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSession);
            int lengthCartBefor = cart.Count;

            CartItem item = cart.Find(el => el.ProductId == id);
            cart.Remove(item);
            HttpContext.Session.SetObjectAsJson(CartSession, cart);

            return Json(lengthCartBefor - cart.Count);
        }

        [Route("/Cart/OrderWithoutAccount/{name}/{phoneNum}/{email}/{address}")]
        public IActionResult OrderWithoutAccount(string name, int phoneNum, string email, string address)
        {
            int result = 0;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(address))
            {
                InfoCustomer infoCustomer = new InfoCustomer()
                {
                    Name = name,
                    PhoneNum = phoneNum.ToString(),
                    Email = email,
                    Address = address
                };
                int createInfoResult = infoRepository.CreateInfoCustomer(infoCustomer);

                if (createInfoResult > 0)
                {
                    var order = new Order()
                    {
                        CreateAt = DateTime.Today,
                        ShipperDate = DateTime.Today,
                        InfoCustomerId = infoCustomer.Id
                    };
                    orderRepository.CreateOrder(order);

                    var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSession);
                    foreach (var item in cart)
                        orderRepository.AddOrderDetailInOrder(order, item.ProductId, item.Amount);

                    result = orderRepository.GetOrderDetailsByOrderId(order.Id).Count;
                    if (result > 0)
                        HttpContext.Session.SetObjectAsJson(CartSession, new List<CartItem>());
                }
            }
            return Json(result);
        }
    }
}
