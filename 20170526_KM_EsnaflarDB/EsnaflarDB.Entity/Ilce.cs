using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsnaflarDB.Entity
{
    public class Ilce   //bütün entityle için tablo oluşturması yaptık
    {
        public int IlceID { get; set; }
        public string IlceAdi { get; set; }
        public int SehirID { get; set; }
    }
}
