using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MotobikeShop.Models;
using MotobikeShop.Repositories;

namespace MotobikeShop.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeRepository homeRepository;

        
        public HomeController(ILogger<HomeController> logger, IHomeRepository homeRepository)
        {
            _logger = logger;
            this.homeRepository = homeRepository;
        }

        [AllowAnonymous]
        public IActionResult Index() =>
            View(homeRepository.Categories);

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult WatchProduct(int id) =>
             View(homeRepository.GetProductsByCateId(id));

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Buy(int id, int amount)
        {
            return Json(amount);
        }
    }
}
