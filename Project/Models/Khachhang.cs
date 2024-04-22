using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Khachhang
    {
        public Khachhang()
        {
            Giaodich = new HashSet<Giaodich>();
        }

        public int Id { get; set; }
        public string Ten { get; set; }
        public int? Sdt { get; set; }
        public string Email { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public int? Socmtnd { get; set; }
        public string Diachi { get; set; }
        public string Avatar { get; set; }
        public DateTime? Ngaymotk { get; set; }
        public int? Sodutk { get; set; }
        public int? Trangthai { get; set; }
        public DateTime? Ngaycapcm { get; set; }
        public string Noicapcm { get; set; }

        public ICollection<Giaodich> Giaodich { get; set; }
    }
}
