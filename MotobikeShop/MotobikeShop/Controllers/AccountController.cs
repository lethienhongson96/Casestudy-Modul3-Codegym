using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MotobikeShop.Models;
using MotobikeShop.Models.Entities;
using MotobikeShop.Models.ViewModels;

namespace MotobikeShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private const string AvatarUserDefault = "DefaultAvatar.png";
        public AccountController(AppDbContext context, IWebHostEnvironment hostEnvironment,
            UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _context = context;
            _hostEnvironment = hostEnvironment;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View(_userManager.Users.ToList());
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Create() => View();

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Create(CreateUserView model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser User = new ApplicationUser()
                {
                    Avatar = AvatarPathForUser(model.Iformfile_path),
                    PhoneNumber = model.PhoneNum,
                    Email = model.Email,
                    UserName = model.Email
                };
                var result = await _userManager.CreateAsync(User, model.Password);

                /*address.ApplicationUserId = User.Id;*/
                await _context.SaveChangesAsync();

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(User, false);
                    return RedirectToAction("Index", "Account");
                }
                else
                    foreach (var item in result.Errors)
                        ModelState.AddModelError("", item.Description);
            }
            return View();
        }

        private string AvatarPathForUser(IFormFile iformfile_path)
        {
            if (iformfile_path == null)
                return AvatarUserDefault;
            else
                return UploadedFile(iformfile_path);
        }

        private string UploadedFile(IFormFile iformfile_path)
        {
            string uniqueFileName = null;

            if (iformfile_path != null)
            {
                string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "images/UserImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + iformfile_path.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using var fileStream = new FileStream(filePath, FileMode.Create);
                iformfile_path.CopyTo(fileStream);
            }
            return uniqueFileName;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login(string returnUrl = "") =>
            View(new LoginViewModel { ReturnUrl = returnUrl });

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                        return Redirect(model.ReturnUrl);
                    else
                        return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Sai Tài Khoản Hoặc Mật Khẩu !");

            return View(model);
        }

        public JsonResult GetDistrictById(int id) =>
            Json(new SelectList(_context.District.Where(x => x.ProvinceId == id).ToList(), "Id", "Name"));

        public JsonResult GetWardById(int id) =>
             Json(new SelectList(_context.Ward.Where(x => x.DistrictId == id).ToList(), "Id", "Name"));

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var User = _userManager.FindByIdAsync(id).Result;

            EditUserView model = new EditUserView()
            {
                Email = User.Email,
                Id = User.Id,
                Avatar_Path = User.Avatar,
                PhoneNum = User.PhoneNumber
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditUserView UserModel)
        {

            var FindUser = _userManager.FindByIdAsync(UserModel.Id).Result;

            FindUser.Email = UserModel.Email;
            FindUser.PhoneNumber = UserModel.PhoneNum;
            FindUser.Avatar = UserModel.Avatar_Path;

            if (UserModel.Iformfile_path != null)
            {
                FindUser.Avatar = UploadedFile(UserModel.Iformfile_path);

                if (!string.IsNullOrEmpty(UserModel.Avatar_Path) && UserModel.Avatar_Path != AvatarUserDefault)
                {
                    string DelPath = Path.Combine(_hostEnvironment.WebRootPath, "Images/UserImages", UserModel.Avatar_Path);
                    System.IO.File.Delete(DelPath);
                }
            }
            await _userManager.UpdateAsync(FindUser);

            return RedirectToAction("Index", "Account");
        }

        [Route("/Account/Delete/{id}")]
        public IActionResult Delete(string id)
        {
            bool deleteResult = false;
            var existUser = Task.Run(async () => await _userManager.FindByIdAsync(id)).Result;

            if (existUser == null)
                return Json(new { deleteResult });

            //Task.Run(async () => await _context.SaveChangesAsync());

            if (existUser.Avatar != AvatarUserDefault)
            {
                string DelPath = Path.Combine(_hostEnvironment.WebRootPath, "Images/UserImages", existUser.Avatar);
                System.IO.File.Delete(DelPath);
            }
            var identityResult = Task.Run(async () => await _userManager.DeleteAsync(existUser)).Result;
            deleteResult = identityResult.Succeeded;

            return Json(new { deleteResult });
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        public IActionResult UserDetail(string id) =>
            View(_userManager.FindByIdAsync(id).Result);

        [HttpGet]
        public IActionResult ChangePass(string id)
        {
            ApplicationUser user = _userManager.FindByIdAsync(id).Result;
            if (user == null)
            {
                ModelState.AddModelError("", "Tài khoản này không tồn tại");
                return RedirectToAction("Index", "Home");
            }
            ChangePassUserView changePassUserView = new ChangePassUserView()
            {
                Id = user.Id,
            };
            return View(changePassUserView);
        }


        [HttpPost]
        public async Task<IActionResult> ChangePass(ChangePassUserView changePassView)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = _userManager.FindByIdAsync(changePassView.Id).Result;
                if (user != null)
                {
                    var result = await _userManager.ChangePasswordAsync(user, changePassView.CurrentPassword, changePassView.NewPassword);

                    if (result.Succeeded)
                    {
                        await _userManager.UpdateAsync(user);
                        return RedirectToAction("Index", "Home");
                    }
                    else
                        foreach (var item in result.Errors)
                            ModelState.AddModelError("", item.Description);
                }
                else
                    return View();
            }

            return View();
        }
    }
}
