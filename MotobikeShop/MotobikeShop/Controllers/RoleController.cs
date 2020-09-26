using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MotobikeShop.Models.ViewModels;

namespace MotobikeShop.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var roles = await _roleManager.Roles.ToListAsync();
            return View(roles);
        }

        [HttpPost]
        public async Task<IActionResult> Addrole(string rolename)
        {
            if (rolename != null)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(rolename.Trim()));

                if (result.Succeeded)
                    return RedirectToAction("Index", "Role");
                else
                    foreach (var item in result.Errors)
                        ModelState.AddModelError("", item.Description);
            }
            return RedirectToAction("Index", "Role");
        }

        //[HttpGet]
        //public IActionResult Edit(string id)
        //{
        //    var identityRole = _roleManager.Roles.FirstOrDefault(r => r.Id == id);

        //    EditRoleView role = new EditRoleView()
        //    {
        //        Role_Name = identityRole.Name,
        //        Role_Id = identityRole.Id
        //    };
        //    return View(role);
        //}

        [Route("/Role/Edit/{id}/{result}")]
        public async Task<IActionResult> Edit(string id, string result)
        {
            bool isSuccess = false;

            var identityRole = await _roleManager.FindByIdAsync(id);
            identityRole.Name = result;
            var identityResult= await _roleManager.UpdateAsync(identityRole);

            if (identityResult.Succeeded)
                isSuccess = true;

            return Json(new { isSuccess });
        }

        [Route("/Role/Delete/{id}")]
        public IActionResult Delete(string id)
        {
            var deleteResult = false;
            var existUser = Task.Run(async () => await _roleManager.FindByIdAsync(id)).Result;

            if (existUser == null)
                return Json(new { deleteResult });

            var identityResult = Task.Run(async () => await _roleManager.DeleteAsync(existUser)).Result;
            deleteResult = identityResult.Succeeded;

            return Json(new { deleteResult });
        }
    }
}
