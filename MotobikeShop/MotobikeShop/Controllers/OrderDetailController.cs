using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MotobikeShop.Enums;
using MotobikeShop.Models.Entities;
using MotobikeShop.Repositories;

namespace MotobikeShop.Controllers
{
    [Authorize(Roles = "Admin")]
    public class OrderDetailController : Controller
    {
        private readonly IOrderDetailRepository detailRepository;

        public OrderDetailController(IOrderDetailRepository detailRepository)
        {
            this.detailRepository = detailRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WatchOrderDetail(int id) =>
            View(detailRepository.GetOrderByid(id));

        [HttpGet]
        public IActionResult Create(int id) =>
            View(detailRepository.CreateByOrderId(id));

        [HttpPost]
        public IActionResult Create(OrderDetail orderDetail)
        {
            if (ModelState.IsValid)
            {
                if (detailRepository.CreateOrderDetail(orderDetail) > 0 && orderDetail.Quantity > 0)
                    return RedirectToAction("WatchOrderDetail", "OrderDetail", detailRepository.GetOrderByid(orderDetail.OrderId));

                ModelState.AddModelError("", "Quantity is not Null");
            }
            else
                ModelState.AddModelError("", TextErrorToView.WrongMess);

            return View(orderDetail);
        }

        public JsonResult GetProductsByCategoryId(int id) =>
             Json(new SelectList(detailRepository.GetListProductByCategoryId(id), "Id", "Name"));

        [Route("/OrderDetail/GetPrice/{ProductId}/{Discount}/{Quantity}")]
        public JsonResult GetPrice(int ProductId, int Discount, int Quantity)
        {
            Product product = detailRepository.GetProductById(ProductId);

            return Json(detailRepository.CalculateMoney(product.PricePerUnit, Discount, Quantity));
        }

        public JsonResult DefaultByProductId(int id)
        {
            Product product = detailRepository.GetProductById(id);

            return Json(product.PricePerUnit);
        }

        [HttpGet]
        public IActionResult Edit(int ProductId, int OrderId) =>
            View(detailRepository.GetOrderDetailByIds(ProductId, OrderId));

        [HttpPost]
        public IActionResult Edit(OrderDetail orderDetail)
        {
            if (detailRepository.UpdateOrderDetail(orderDetail) > 0)
                return RedirectToAction("WatchOrderDetail", "OrderDetail", detailRepository.GetOrderByid(orderDetail.OrderId));

            return View(orderDetail);
        }

        [Route("/OrderDetail/Delete/{OrderId}/{ProductId}")]
        public IActionResult Delete(int OrderId, int ProductId)
        {
            var result = detailRepository.DeleteOrderDetail(OrderId, ProductId);
            return Json(new { result });
        }
    }
}
