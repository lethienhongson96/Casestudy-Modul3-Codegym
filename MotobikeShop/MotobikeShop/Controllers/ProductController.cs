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
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View(productRepository.ProductList);
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(CreateProductView productView)
        {
            if (ModelState.IsValid)
            {
                if (productRepository.CreateProduct(productView) > 0)
                    return RedirectToAction("Index", "Product");

                ModelState.AddModelError("", TextErrorToView.WrongMess);
            }
            return View();
        }

        [Route("/Product/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = productRepository.DeleteProduct(id);
            return Json(new { result });
        }

        [HttpGet]
        public IActionResult Edit(int id) => View(productRepository.FindProductToView(id));

        [HttpPost]
        public IActionResult Edit(EditProductView productView)
        {
            if (productView.Price <= 0)
            {
                ModelState.AddModelError("","Số tiền không hợp lệ");
                return View(productView);
            }
            if (ModelState.IsValid)
            {
                if (productRepository.UpdateProduct(productView) > 0)
                    return RedirectToAction("Index", "Product");
            }
            return View(productView);
        }

        [HttpGet]
        public IActionResult Restore() => View(productRepository.GetInActiveProducts());

        [HttpPost]
        public IActionResult Restore(List<ReStoreView> ReStoreViews)
        {
            int result = productRepository.RestoreProducts(ReStoreViews);

            if (result > 0 || result == 0)
                return RedirectToAction("Index", "Product");

            ModelState.AddModelError("", TextErrorToView.WrongMess);

            return View(ReStoreViews);

        }
    }
}
