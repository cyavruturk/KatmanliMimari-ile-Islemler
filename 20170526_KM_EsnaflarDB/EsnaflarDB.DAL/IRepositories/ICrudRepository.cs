using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsnaflarDB.DAL.IRepositories
{
    interface ICrudRepository<Entity, ID>:IAdd<Entity>,IUpdate<Entity>,IDelete<Entity>,IGet<Entity,ID> where Entity:class
    {
        //bütün interfaceleri tek bir interface üzerinde toplamak gerekli olanları çağırmak için kullandık
    }
}
