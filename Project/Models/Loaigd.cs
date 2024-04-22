using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Loaigd
    {
        public Loaigd()
        {
            Giaodich = new HashSet<Giaodich>();
        }

        public int Id { get; set; }
        public string Tengd { get; set; }
        public int? Trangthai { get; set; }
        public int? Ma { get; set; }

        public ICollection<Giaodich> Giaodich { get; set; }
    }
}
