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
    public class KategoriController
    {
        KategoriManagement km;

        public KategoriController()
        {
            km = new KategoriManagement();
        }

        public bool Ekle(int KategoriID, string KategoriAdi)   //Kategori eklemesi yapmak için metot oluşturduk
        {
            Kategori kategori = new Kategori();
            kategori.KategoriID = KategoriID;
            kategori.KategoriAdi = KategoriAdi;

            return km.Add(kategori);

        }

    }
}
