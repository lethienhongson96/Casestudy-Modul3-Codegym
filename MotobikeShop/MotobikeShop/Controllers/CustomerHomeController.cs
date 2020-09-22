using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MotobikeShop.Models;
using MotobikeShop.Models.CartSession;
using MotobikeShop.Repositories;

namespace MotobikeShop.Controllers
{
    public class CustomerHomeController : Controller
    {
        private const string CartSession = "CartSession";
        private readonly ICategoryRepository categoryRepository;

        public CustomerHomeController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>("CartSession");
            if (cart == null)
                HttpContext.Session.SetObjectAsJson("CartSession", new List<CartItem>());
            else
                HttpContext.Session.SetObjectAsJson("CartSession", cart);

            return View(categoryRepository.Categories);
        }

        [HttpGet]
        public IActionResult WatchProducts(int id)
        {
            return View(categoryRepository.GetProductsByCategoryId(id));
        }

        public IActionResult WatchCart()
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSession);
            HttpContext.Session.SetObjectAsJson(CartSession, cart);

            return View(cart);
        }
    }
}
