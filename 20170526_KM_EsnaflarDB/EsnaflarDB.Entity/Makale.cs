using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsnaflarDB.Entity
{
    public class Makale
    {
        public int MakaleID { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }
        public int CategoryID { get; set; }
        public DateTime KayitTarihi { get; set; }
        public Guid YazarID { get; set; }
        public int OkunmaSayisi { get; set; }
        public int ToplamPuan { get; set; }
        public int OyVerenKisiSayisi { get; set; }
    }
}
