using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Taikhoan
    {
        public Taikhoan()
        {
            Roleid = new HashSet<Roleid>();
            TaikhoanNhanvien = new HashSet<TaikhoanNhanvien>();
        }

        public int Id { get; set; }
        public int? Loaitk { get; set; }
        public string Ten { get; set; }
        public int? Sdt { get; set; }
        public string Email { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public int? Socmtnd { get; set; }
        public string Diachi { get; set; }
        public string Avatar { get; set; }
        public int? Trangthai { get; set; }
        public int? Chinhanh { get; set; }
        public string Makhau { get; set; }

        public ICollection<Roleid> Roleid { get; set; }
        public ICollection<TaikhoanNhanvien> TaikhoanNhanvien { get; set; }
    }
}
