using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Microsoft.AspNetCore.Authorization;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ChiNhanhController : Controller
    {
        private NGANHANGContext DB;

        public ChiNhanhController(NGANHANGContext DB) => this.DB = DB;

        public IActionResult Index(string search, int id)
        {
            var ChiNhanh = DB.Chinhanh.Where(x => x.Tangthai == 1);
            if(id > 0)
            {
                var edit = DB.Chinhanh.FirstOrDefault(X => X.Id == id);
                ViewBag.edit = edit;
            }
            else
            {
                ViewBag.edit = new Chinhanh();
            }
            return View(ChiNhanh);
        }

        [HttpPost]
        public IActionResult Create(int Id, string Ten, string Diachi)
        {
            Boolean check = true;
            if (string.IsNullOrEmpty(Ten))
            {
                ViewBag.Ten = "Vui lòng nhập tên chi nhánh";
                check = false;
            }
            if (string.IsNullOrEmpty(Diachi))
            {
                ViewBag.Ten = "Vui lòng nhập địa chỉ";
                check = false;
            }

            var Chinhanh = new Chinhanh();
            Chinhanh.Tenchinhanh = Ten;
            Chinhanh.Diachi = Diachi;
            Chinhanh.Tangthai = 1;
            Chinhanh.Id = Id;
            if (check == true)
            {
                if (Id == 0)
                {
                    DB.Chinhanh.Add(Chinhanh);
                    DB.SaveChanges();
                    TempData["OK"] = "Thêm Mới Thành Công";
                    return Redirect("Index");
                }
                else
                {
                    DB.Update(Chinhanh);
                    DB.SaveChanges();
                    TempData["OK"] = "Cập Nhật Thàng Công";
                    return Redirect("Index");
                }
            }
            
            ViewBag.edit = Chinhanh;
            return Redirect("Index");
        }

        public IActionResult Delete(int id)
        {
            var chinhanh = DB.Chinhanh.FirstOrDefault(x => x.Id == id);
            chinhanh.Tangthai = 0;
            DB.Update(chinhanh);
            DB.SaveChanges();
            TempData["OK"] = "Xoá Thàng Công";
            return Redirect("Index");
        }
    }
}