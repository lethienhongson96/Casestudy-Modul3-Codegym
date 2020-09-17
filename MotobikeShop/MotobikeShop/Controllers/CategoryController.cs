using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MotobikeShop.Enums;
using MotobikeShop.Models.Entities;
using MotobikeShop.Models.ViewModels;
using MotobikeShop.Repositories;

namespace MotobikeShop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View(categoryRepository.GetCategories());
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                if (categoryRepository.CreateCategory(category) > 0)
                    return RedirectToAction("Index", "Category");

                ModelState.AddModelError("", TextErrorToView.WrongMess);
            }
            return View(category);
        }

        [HttpGet]
        public IActionResult Edit(int id) => View(categoryRepository.GetCategoryById(id));

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                if (categoryRepository.UpdateCategory(category) > 0)
                    return RedirectToAction("Index", "Category");

                ModelState.AddModelError("", TextErrorToView.WrongMess);
            }

            return View();
        }

        [HttpGet]
        public IActionResult WatchProducts(int id) =>
             View(categoryRepository.GetCategoryById(id));

        [Route("/Category/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = categoryRepository.DeleteCategory(id);
            return Json(new { result });
        }

        [Route("/Category/RemoveProductFromCategory/{id}")]
        public IActionResult RemoveProductFromCategory(int id)
        {
            var result = categoryRepository.MoveCategoryForProduct(id);
            return Json(new { result });
        }

        [HttpGet]
        public IActionResult MoveDefaultToAnother(int id) =>
             View(categoryRepository.GetListMoveDefaultViewByCateId(id));

        [HttpPost]
        public ActionResult MoveDefaultToAnother(List<MoveDefaultView> MoveDefaultViews)
        {
            var ProductList = new List<Product>();

            foreach (var item in MoveDefaultViews)
            {
                var Product = categoryRepository.GetProductById(item.Id);
                Product.CategoryId = item.CategoryId;
                ProductList.Add(Product);
            }
            if (categoryRepository.MoveRangeCategoryForProduct(ProductList) > 0)
                return RedirectToAction("Index", "Category");

            return View(MoveDefaultViews);
        }
    }
}
