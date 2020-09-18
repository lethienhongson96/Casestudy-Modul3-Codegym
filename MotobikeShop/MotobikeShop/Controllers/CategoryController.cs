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

        [HttpGet]
        public IActionResult Index() => View(categoryRepository.Categories);

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
        public IActionResult WatchProducts(int id) => View(categoryRepository.GetProductsByCategoryId(id));

        [Route("/Category/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            var result = categoryRepository.DeleteCategory(id);
            return Json(new { result });
        }

        [Route("/Category/RemoveProductFromCategory/{id}")]
        public IActionResult RemoveProductFromCategory(int id)
        {
            var result = categoryRepository.RemoveProduct(id);
            return Json(new { result });
        }

        [HttpGet]
        public IActionResult Restore() => View(categoryRepository.GetInActiveCategories());


        [HttpPost]
        public IActionResult Restore(List<ReStoreView> reStoreCategoryViews)
        {
            int result = categoryRepository.RestoreCategories(reStoreCategoryViews);

            if (result > 0 || result == 0)
                return RedirectToAction("Index", "Category");

            ModelState.AddModelError("", TextErrorToView.WrongMess);

            return View(reStoreCategoryViews);

        }
    }
}
