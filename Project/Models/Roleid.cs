using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Roleid
    {
        public int Id { get; set; }
        public int? Taikhoanid { get; set; }
        public int? Menu { get; set; }
        public int? Them { get; set; }
        public int? Sua { get; set; }
        public int? Xoa { get; set; }
        public int? Trangthai { get; set; }

        public Menu MenuNavigation { get; set; }
        public Taikhoan Taikhoan { get; set; }
    }
}
