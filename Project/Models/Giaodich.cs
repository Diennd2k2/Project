using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Giaodich
    {
        public Giaodich()
        {
            TaikhoanNhanvien = new HashSet<TaikhoanNhanvien>();
        }

        public int Id { get; set; }
        public int? Makhachang { get; set; }
        public int? Maloaigd { get; set; }
        public int? Makhachhangnhan { get; set; }
        public int? Sotien { get; set; }
        public DateTime? Ngaygd { get; set; }
        public string Noidung { get; set; }
        public int? Trangthai { get; set; }

        public Khachhang MakhachangNavigation { get; set; }
        public Loaigd MaloaigdNavigation { get; set; }
        public ICollection<TaikhoanNhanvien> TaikhoanNhanvien { get; set; }
    }
}
