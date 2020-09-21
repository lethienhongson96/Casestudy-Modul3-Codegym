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

        [Route("/Cart/AddItem/{id}/{amount}")]
        public IActionResult AddItem(int id, int amount)
        {
            CartItem item = new CartItem() { ProductId = id, Amount = amount };
            var cart = HttpContext.Session.GetObjectFromJson<List<CartItem>>(CartSession);

            if (cart != null)
            {
                if (cart.Exists(el => el.ProductId == id))
                {
                    cart.Find(el => el.ProductId == id).Amount += amount;
                    return Json(cart.Count);
                }
                else
                {
                    //CartItem item = new CartItem() { ProductId = productid, Amount = amount };
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
