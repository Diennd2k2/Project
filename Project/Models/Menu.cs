using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class Menu
    {
        public Menu()
        {
            Roleid = new HashSet<Roleid>();
        }

        public int Id { get; set; }
        public string Ten { get; set; }
        public int? Macha { get; set; }
        public string Controller { get; set; }
        public string Roule { get; set; }
        public int? Trangthai { get; set; }

        public ICollection<Roleid> Roleid { get; set; }
    }
}
