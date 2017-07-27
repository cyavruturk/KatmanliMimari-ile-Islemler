using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace EsnaflarDB.BLL.GirisController
{
    public class GirisController    //Eşleşme doğru mu değilmi Controlu
    {
        public bool EslesmeKontrol(string kadi, string sifre)
        {
            bool eslestimi = Membership.ValidateUser(kadi, sifre);
            return eslestimi;
        }
    }
}
