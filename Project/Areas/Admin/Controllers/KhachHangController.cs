using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using X.PagedList;

namespace Project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class KhachHangController : Controller
    {
        private NGANHANGContext DB;

        public KhachHangController(NGANHANGContext DB) => this.DB = DB;

        public IActionResult Index(string search , int page = 1)
        {
            int limit = 10;
            if (!string.IsNullOrEmpty(search))
            {
                var nhanvien = DB.Khachhang.Where(x => x.Ten.Contains(search)).OrderByDescending(x => x.Id).ToPagedList(page, limit);
                return View(nhanvien);
            }
            else
            {
                var nhanvien = DB.Khachhang.OrderByDescending(x => x.Id).OrderByDescending(x => x.Id).ToPagedList(page, limit);
                return View(nhanvien);
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Khachhang tk)
        {
            Boolean check = true;
            if (string.IsNullOrEmpty(tk.Ten))
            {
                ViewBag.Ten = "Vui lòng nhập tên";
                check = false;
            }
            if (tk.Sdt == null)
            {
                ViewBag.Sdt = "Vui lòng nhập số điện thoại";
                check = false;
            }
            if (tk.Sdt != null)
            {
                var sdd = DB.Taikhoan.Where(x => x.Sdt == tk.Sdt).ToList();
                if (sdd.Count > 0)
                {
                    ViewBag.Sdtt = "Số điện thoại đá được đăng ký";
                    check = false;
                }
            }
            if (string.IsNullOrEmpty(tk.Email))
            {
                ViewBag.Email = "Vui lòng nhập Email";
                check = false;
            }
            if (tk.Socmtnd == null)
            {
                ViewBag.Socmtnd = "Vui lòng nhập CMND/CCCD";
                check = false;
            }
            if (tk.Socmtnd != null)
            {
                var sdd = DB.Taikhoan.Where(x => x.Sdt == tk.Sdt).ToList();
                if (sdd.Count > 0)
                {
                    ViewBag.Socmtndd = "Số CMMND/CCCD đá được đăng ký";
                    check = false;
                }
            }
            if (string.IsNullOrEmpty(tk.Diachi))
            {
                ViewBag.Diachi = "Vui lòng nhập địa chỉ";
                check = false;
            }
            if (string.IsNullOrEmpty(tk.Ngaysinh.ToString()))
            {
                ViewBag.Ngaysinh = "Vui lòng nhập ngày sinh";
                check = false;
            }

            if (string.IsNullOrEmpty(tk.Noicapcm.ToString()))
            {
                ViewBag.Ngaycapcm = "Vui lòng nhập ngày cấp";
            }
            if (string.IsNullOrEmpty(tk.Noicapcm))
            {
                ViewBag.Noicapcm = "Vui lòng nhập nơi cấp";
            }

            var files = HttpContext.Request.Form.Files;
            if (files.Count() > 0 && files[0].Length > 0)
            {
                var file = files[0];
                var FileName = file.FileName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                    tk.Avatar = FileName;
                }
            }
            else
            {
                tk.Avatar = "Avatar.png";
            }
            if (check == true)
            {
                tk.Sodutk = 0;
                DB.Khachhang.Add(tk);
                DB.SaveChanges();
                TempData["OK"] = "Thêm Mới Thành Công";
                return Redirect("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Edit(int id, int loai)
        {
            var khachhang = DB.Khachhang.FirstOrDefault(x => x.Id == id);
            ViewBag.ngaysinhEDIT = khachhang.Ngaysinh?.ToString("yyyy-MM-dd");
            ViewBag.ngaycapEDIT = khachhang.Ngaycapcm?.ToString("yyyy-MM-dd");
            return View(khachhang);
        }


        [HttpPost]
        public IActionResult Edit(Khachhang tk)
        {
            Boolean check = true;
            if (string.IsNullOrEmpty(tk.Ten))
            {
                ViewBag.Ten = "Vui lòng nhập tên";
                check = false;
            }
            if (tk.Sdt == null)
            {
                ViewBag.Sdt = "Vui lòng nhập số điện thoại";
                check = false;
            }
            if (tk.Sdt != null)
            {
                var sdd = DB.Taikhoan.Where(x => x.Sdt == tk.Sdt).ToList();
                if (sdd.Count > 0)
                {
                    ViewBag.Sdtt = "Số điện thoại đá được đăng ký";
                    check = false;
                }
            }
            if (string.IsNullOrEmpty(tk.Email))
            {
                ViewBag.Email = "Vui lòng nhập Email";
                check = false;
            }
            if (tk.Socmtnd == null)
            {
                ViewBag.Socmtnd = "Vui lòng nhập CMND/CCCD";
                check = false;
            }
            if (tk.Socmtnd != null)
            {
                var sdd = DB.Taikhoan.Where(x => x.Sdt == tk.Sdt).ToList();
                if (sdd.Count > 0)
                {
                    ViewBag.Socmtndd = "Số CMMND/CCCD đá được đăng ký";
                    check = false;
                }
            }
            if (string.IsNullOrEmpty(tk.Diachi))
            {
                ViewBag.Diachi = "Vui lòng nhập địa chỉ";
                check = false;
            }
            if (string.IsNullOrEmpty(tk.Ngaysinh.ToString()))
            {
                ViewBag.Ngaysinh = "Vui lòng nhập ngày sinh";
                check = false;
            }
            if (string.IsNullOrEmpty(tk.Noicapcm.ToString()))
            {
                ViewBag.Ngaycapcm = "Vui lòng nhập ngày cấp";
            }
            if (string.IsNullOrEmpty(tk.Noicapcm))
            {
                ViewBag.Noicapcm = "Vui lòng nhập nơi cấp";
            }

            var files = HttpContext.Request.Form.Files;
            if (files.Count() > 0 && files[0].Length > 0)
            {
                var file = files[0];
                var FileName = file.FileName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                    tk.Avatar = FileName;
                }
            }   
            if (check == true)
            {
                DB.Update(tk);
                DB.SaveChanges();
                TempData["OK"] = "Cập Nhật Thàng Công";
                return Redirect("Index");
            }
            else
            {
                var khachhang = DB.Khachhang.FirstOrDefault(x => x.Id == tk.Id);
                ViewBag.ngaysinhEDIT = khachhang.Ngaysinh?.ToString("yyyy-MM-dd");
                ViewBag.ngaycapEDIT = khachhang.Ngaycapcm?.ToString("yyyy-MM-dd");
                return View(khachhang);
            }
        }

        public IActionResult Delete(int id)
        {
            var tk = DB.Khachhang.FirstOrDefault(x => x.Id == id);
            tk.Trangthai = 0;
            DB.Update(tk);
            DB.SaveChanges();
            TempData["OK"] = "Xoá thành Thàng Công";
            return Redirect("Index");
        }

        public IActionResult createGD(int idkh)
        {
            ViewBag.tk = DB.Khachhang.FirstOrDefault(x => x.Id == idkh);
            ViewBag.listtk = DB.Khachhang.Where(x => x.Trangthai == 1 && x.Id != idkh);
            ViewBag.LoaiGD = DB.Loaigd.Where(x => x.Trangthai == 1); 
            return View();
        }

    }
}