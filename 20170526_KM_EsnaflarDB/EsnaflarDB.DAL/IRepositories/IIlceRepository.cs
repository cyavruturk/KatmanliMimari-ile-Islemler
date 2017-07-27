using System;
using EsnaflarDB.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EsnaflarDB.DAL.IRepositories
{
    interface IIlceRepository:IGet<Ilce, int>
    {
        List<Ilce> GetAllForCity(int cityId);
    }
}
