using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsnaflarDB.DAL.Repositories;
using EsnaflarDB.Entity;
using EsnaflarDB.DTO;

namespace EsnaflarDB.BLL.DtoController
{
    public class DtoKategoriMakaleController   //2 tabloyu birleştirebilmek için ayrıca kontrol yaptık
    {
        KategoriManagement km = new KategoriManagement();
        MakaleManagement mm = new MakaleManagement();

        public List<DtoKategoriMakale> KategoriBilgiGetir()
        {
            List<Kategori> kategoriler = km.Get();
            List<DtoKategoriMakale> dtoKategoriMakaleler = new List<DtoKategoriMakale>();

            if (kategoriler.Count > 0)
            {
                foreach (Kategori item in kategoriler)
                {
                    DtoKategoriMakale dtokategoriMakale = new DtoKategoriMakale();
                    dtokategoriMakale.KategoriID = item.KategoriID;
                    dtokategoriMakale.KategoriAdi = item.KategoriAdi;
                    dtokategoriMakale.MakaleSayisi = mm.GetForKategori(item.KategoriID).Count;
                    dtoKategoriMakaleler.Add(dtokategoriMakale);
                }
            }
            return dtoKategoriMakaleler;
        }
    }
}
