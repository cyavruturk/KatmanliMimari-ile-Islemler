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
    public class UyeKisiselController
    {
        UyeKisiselManagement ukm;

        public UyeKisiselController()
        {
            ukm = new UyeKisiselManagement();
        }

        public bool Ekle(Guid UyeID, string Ad, string Soyad, bool Cinsiyet, DateTime DogumTarihi, string Telefon, string adres, int IlceID)    //kullanıcı profli oluşturma kısmı
        {
            UyeKisisel uyeKisisel = new UyeKisisel();
            uyeKisisel.UyeID = UyeID;      //Uye id uniqidentity olduğu için visual studioda karşılığı guid onu kullandık
            uyeKisisel.Ad = Ad;
            uyeKisisel.Soyad = Soyad;
            uyeKisisel.Cinsiyet = Cinsiyet;
            uyeKisisel.DogumTarihi = DogumTarihi;
            uyeKisisel.Telefon = Telefon;
            uyeKisisel.Adres = adres;
            uyeKisisel.IlceID = IlceID;

            return ukm.Add(uyeKisisel);

        }
    }
}
