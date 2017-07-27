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
    public class YorumController
    {
        YorumlarManagement ym;
        public YorumController()
        {
            ym = new YorumlarManagement();
        }

        public bool Ekle(int YorumID, string AdSoyad, string YorumIcerik, string Email, int MakaleID, string WebSitesi, bool Onaylandimi, DateTime YorumTarihi)
        {
            Yorum yorum = new Yorum();    //yorum ekleme metodu
            yorum.YorumID = YorumID;
            yorum.AdSoyad = AdSoyad;
            yorum.YorumIcerik = YorumIcerik;
            yorum.Email = Email;
            yorum.MakaleID = MakaleID;
            yorum.WebSitesi = WebSitesi;
            yorum.Onaylandimi = Onaylandimi;
            yorum.YorumTarihi = YorumTarihi;

            return ym.Add(yorum);

        }
    }
}
