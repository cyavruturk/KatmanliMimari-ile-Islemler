using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsnaflarDB.DTO;
using System.Web.Security;

namespace EsnaflarDB.DAL.IRepositories
{
    interface IUserRepository
    {
        MembershipCreateStatus Add(DtoUser user);    //Userla geleceği için yeni üyelik oluşturacağımız management
        Guid GetUserID(string UserName);
    }
}
