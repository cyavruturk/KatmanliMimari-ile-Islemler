using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EsnaflarDB.BLL.DtoController;
using Extension;

namespace EsnaflarDB.UI
{
    public partial class Site : System.Web.UI.MasterPage
    {
        DtoKategoriMakaleController _kc;
        public Site()
        {
            _kc = new DtoKategoriMakaleController();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }
        private void KategoriGetir()
        {
            try
            {
                rptKategoriler.DataSource = _kc.KategoriBilgiGetir();
                rptKategoriler.DataBind();
            }
            catch (Exception ex)
            {
                Helper.MesajGoster((Page)HttpContext.Current.CurrentHandler, ex.Message);
            }
        }
    }
}