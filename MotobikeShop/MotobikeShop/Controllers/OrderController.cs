using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MotobikeShop.Models.Entities;
using MotobikeShop.Repositories;

namespace MotobikeShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public IActionResult Index()
        {
            return View(orderRepository.GetOrderList());
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                if (orderRepository.CreateOrder(order) > 0)
                    return RedirectToAction("Index", "Order");

                ModelState.AddModelError("", TextErrorToView.WrongMess);
            }
            return View(order);
        }

        [Route("/Order/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = orderRepository.DeleteOrder(id);
            return Json(new { result });
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(orderRepository.GetOrder(id));
        }

        [HttpPost]
        public IActionResult Edit(Order order)
        {
            if (orderRepository.UpdateOrder(order) > 0)
                return RedirectToAction("Index", "Order");

            ModelState.AddModelError("", TextErrorToView.WrongMess);

            return View(order);
        }
    }
}
