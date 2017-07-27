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
    public class IlceController
    {
        IlceManagement im;

        public IlceController()
        {
            im = new IlceManagement();
        }

        public List<Ilce> IlceGetir(int id)       //Bütün ilçeleri getirebilmek için GetAllForCity metodu kullandık. 
        {
            List<Ilce> ilceler = im.GetAllForCity(id);

            return ilceler;
        }

        //public bool Ekle(int IlceID, string IlceAdi, int SehirID)
        //{
        //    Ilce ilce = new Ilce();
        //    ilce.IlceID = IlceID;
        //    ilce.IlceAdi = IlceAdi;
        //    ilce.SehirID = SehirID;

        //    return im.Add(ilce);

        //}
    }
}
