using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsnaflarDB.DTO
{
    public class DtoKategoriMakale     //ortak bir sayfaları olduğu için ortak bir yapı oluşturmamız gerekti
    {
        public int KategoriID { get; set; }

        public string KategoriAdi { get; set; }

        public int MakaleSayisi { get; set; }
    }
}
