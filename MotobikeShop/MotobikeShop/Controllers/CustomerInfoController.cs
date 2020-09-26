using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MotobikeShop.Repositories;

namespace MotobikeShop.Controllers
{
    public class CustomerInfoController : Controller
    {
        private readonly ICustomerInfoRepository customerInfoRepository;

        public CustomerInfoController(ICustomerInfoRepository customerInfoRepository)
        {
            this.customerInfoRepository = customerInfoRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CustomerDetail(int id) => View(customerInfoRepository.GetInfoCustomerById(id));
    }
}
