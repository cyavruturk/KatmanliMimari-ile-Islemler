using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsnaflarDB.DAL;
using EsnaflarDB.Entity;
using EsnaflarDB.DAL.Repositories;

namespace EsnaflarDB.BLL
{
    public class MakaleController
    {
        MakaleManagement mm;

        public MakaleController()
        {
            mm = new MakaleManagement();
        }

        public bool Ekle(string Baslik, string Icerik, int CategoryID, Guid YazarID) // aynı şekilde makale eklemesi yapması için oluşturduk
        {
            Makale makale = new Makale();
            makale.Baslik = Baslik;
            makale.Icerik = Icerik;
            makale.CategoryID = CategoryID;
            makale.YazarID = YazarID;
            //makale.OkunmaSayisi = OkunmaSayisi;

            return mm.Add(makale);

        }
    }
}
