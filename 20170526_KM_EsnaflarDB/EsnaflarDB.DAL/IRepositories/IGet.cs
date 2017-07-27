using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsnaflarDB.DAL.IRepositories
{
    interface IGet<Entity, ID> where Entity:class
    {
        List<Entity> Get();   //liste getir işlemi

        Entity Get(ID id);       //Get içeriisnde ID tipinde id getir
    }
}
