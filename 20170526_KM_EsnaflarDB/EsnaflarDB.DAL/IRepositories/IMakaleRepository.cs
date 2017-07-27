using EsnaflarDB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsnaflarDB.DAL.IRepositories
{
    interface IMakaleRepository: IGet<Makale,int>     //Kategori ile beraber geleceği için ayrıca oluşturmamız gerekti
    {
        List<Makale> GetForKategori(int id);
    }
}
