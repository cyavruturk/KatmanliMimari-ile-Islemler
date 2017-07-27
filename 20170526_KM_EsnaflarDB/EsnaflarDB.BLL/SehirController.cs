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
    public class SehirController
    {
        SehirManagement sm;

        public SehirController()
        {
            sm = new SehirManagement();
        }
        public List<Sehir> SehirGetir()
        {
            List<Sehir> sehirler = sm.Get();

            return sehirler;
        }

        //public bool Ekle(int SehirID, string SehirAdi)
        //{
        //    Sehir sehir = new Sehir();
        //    sehir.SehirID = SehirID;
        //    sehir.SehirAdi = SehirAdi;

        //    return sm.Add(sehir);

        //}
    }
}
