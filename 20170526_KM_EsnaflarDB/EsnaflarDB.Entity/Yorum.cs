using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsnaflarDB.Entity
{
    public class Yorum
    {
        public int YorumID { get; set; }
        public string AdSoyad { get; set; }
        public string YorumIcerik { get; set; }
        public string Email { get; set; }
        public int MakaleID { get; set; }
        public string WebSitesi { get; set; }
        public bool Onaylandimi { get; set; }
        public DateTime YorumTarihi { get; set; }
    }
}
