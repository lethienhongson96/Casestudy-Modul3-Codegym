using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MotobikeShop.Models;
using MotobikeShop.Models.CartSession;
using System.Collections.Generic;

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

        public IActionResult AddItem(int productid, int amount)
        {
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSession);
            if (cart != null)
            {
                if (cart.Exists(el => el.ProductId == productid))
                    cart.Find(el => el.ProductId == productid).Amount += amount;
                else
                {
                    var item = new CartItem() { ProductId = productid, Amount = amount };
                    cart.Add(item);
                    HttpContext.Session.SetObjectAsJson(CartSession, cart);
                }
            }
            else
            {
                var item = new CartItem() { ProductId = productid, Amount = amount };
                cart.Add(item);
                HttpContext.Session.SetObjectAsJson(CartSession, cart);
            }
            return RedirectToAction("Index");
        }
    }
}
