using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MotobikeShop.Repositories;

namespace MotobikeShop.Controllers
{
    public class CustomerHomeController : Controller
    {
        private readonly ICategoryRepository categoryRepository;

        public CustomerHomeController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IActionResult Index()
        {
            return View(categoryRepository.Categories);
        }

        [HttpGet]
        public IActionResult WatchProducts(int id)
        {
            return View(categoryRepository.GetProductsByCategoryId(id));
        }
    }
}
