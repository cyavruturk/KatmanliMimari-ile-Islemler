using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EsnaflarDB.DAL.IRepositories;
using System.Web.Security;
using EsnaflarDB.DTO;

namespace EsnaflarDB.DAL.Repositories
{
    public class DtoUserManagement: IUserRepository    //yeni bir hesap oluşturmak için gerekli durumları yazdırdık
    {
        public MembershipCreateStatus Add(DtoUser user)
        {
            MembershipCreateStatus status;
            Membership.CreateUser(user.UserName, user.Password, user.Email, user.PasswordQuestion, user.PasswordAnswer, user.IsApproved, out status);
            return status;

        }

        public Guid GetUserID(string UserName)
        {
            return (Guid)Membership.GetUser(UserName).ProviderUserKey;
        }
    }
}
