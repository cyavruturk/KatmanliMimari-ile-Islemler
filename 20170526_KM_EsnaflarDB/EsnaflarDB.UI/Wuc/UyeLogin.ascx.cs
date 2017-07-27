using EsnaflarDB.BLL.GirisController;
using Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EsnaflarDB.UI.Wuc
{
    public partial class UyeLogin : System.Web.UI.UserControl
    {
        GirisController giriscontrol = new GirisController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void GirisKarsilastirma()
        {
            string kontrolkAdi = ((TextBox)LoginView1.FindControl("txtkadi")).Text;
            string kontrolsifre = ((TextBox)LoginView1.FindControl("txtkadi")).Text;
            bool beniHatirla = ((CheckBox)LoginView1.FindControl("chhatirla")).Checked;

            bool eslestimi = giriscontrol.EslesmeKontrol(kontrolkAdi, kontrolsifre);

            if (eslestimi == true)
            {
                FormsAuthentication.RedirectFromLoginPage(kontrolkAdi, beniHatirla);
            }
            else
            {
                Helper.MesajGoster((Page)HttpContext.Current.CurrentHandler, "Kullanıcı Adı veya Şifre Hatalı!");
            }

        }

        protected void btngiris_Click(object sender, EventArgs e)
        {
            GirisKarsilastirma();
        }

        protected void lnk_cikis_click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Default.aspx");
        }
    }
}