using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MotobikeShop.Models;
using MotobikeShop.Models.CartSession;
using System.Collections.Generic;
using System.Linq;

namespace MotobikeShop.Controllers
{
    public class CartController : Controller
    {
        private const string CartSession = "CartSession";
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
                if (cart.Exists(el=>el.ProductId== item.ProductId))
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
    }
}
