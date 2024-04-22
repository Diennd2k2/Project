using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class TaikhoanNhanvien
    {
        public int Id { get; set; }
        public int? Manhanvien { get; set; }
        public int? Magiaodich { get; set; }

        public Giaodich MagiaodichNavigation { get; set; }
        public Taikhoan ManhanvienNavigation { get; set; }
    }
}
