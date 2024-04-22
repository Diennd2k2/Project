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

        public IActionResult Index()
        {
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
                var Acount = DB.Taikhoan.Where(x => x.Sdt == int.Parse(phone) && x.Makhau == password);
                if(Acount != null)
                {
                    var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, phone) }, "Authen");
                    var principal = new ClaimsPrincipal(identity);
                    var login = HttpContext.SignInAsync("Bkap2022", principal);
                    return Redirect("/Admin/Home/Index");
                }
                else
                {            
                    ViewBag.error = "Email hoặc mật khẩu không đúng";
                    return View();         
                }
            }
        }
    }
}