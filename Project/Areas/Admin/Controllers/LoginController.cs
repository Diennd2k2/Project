using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Project.Models;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private NGANHANGContext DB;

        public LoginController(NGANHANGContext DB) => this.DB = DB;

        public IActionResult Index(string returnUrl)
        {
            ViewData["returnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string phone, string password)
        {
            if(string.IsNullOrEmpty(phone) && string.IsNullOrEmpty(password))
            {
                ViewBag.error = "Lỗi đăng nhập";
                return Redirect("~/Admin/Login/Index");
            }
            else
            {
                var Acount = DB.Taikhoan.FirstOrDefault(x => x.Sdt == int.Parse(phone) && x.Makhau == password);
                if(Acount != null)
                {
                    var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, Acount.Email) }, "SecuritySchema");
                    var principal = new ClaimsPrincipal(identity);
                    HttpContext.SignInAsync("SecuritySchema", principal);
                    return RedirectToAction("Index", "Home");
                }
                else
                {            
                    ViewBag.error = "Email hoặc mật khẩu không đúng";
                    return View();         
                }
            }
        }
        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync("SecuritySchema");

            return RedirectToAction("Index", "Home");
        }
    }
}