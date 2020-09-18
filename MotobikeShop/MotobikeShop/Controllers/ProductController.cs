using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MotobikeShop.Enums;
using MotobikeShop.Models.ViewModels;
using MotobikeShop.Repositories;

namespace MotobikeShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View(_productRepository.ProductList);
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CreateProductView productView)
        {
            if (ModelState.IsValid)
            {
                if (_productRepository.CreateProduct(productView) > 0)
                    return RedirectToAction("Index", "Product");

                ModelState.AddModelError("", TextErrorToView.WrongMess);
            }
            return View();
        }

        [Route("/Product/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = _productRepository.DeleteProduct(id);
            return Json(new { result });
        }

        [HttpGet]
        public IActionResult Edit(int id) =>
            View(_productRepository.FindProductToView(id));

        [HttpPost]
        public IActionResult Edit(EditProductView productView)
        {
            if (ModelState.IsValid)
            {
                if (_productRepository.UpdateProduct(productView) > 0)
                    return RedirectToAction("Index", "Product");
            }
            return View(productView);
        }
    }
}
