using EsnaflarDB.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EsnaflarDB.BLL.DtoController;

namespace EsnaflarDB.UI
{
    public partial class MakaleEkle : System.Web.UI.Page
    {
        DtoKategoriMakaleController dkm = new DtoKategoriMakaleController();
        public void Page_Load(object sender, EventArgs e)
        {
            KategoriController kc = new KategoriController();

            ddlkategori.DataSource = dkm.KategoriBilgiGetir();
            ddlkategori.DataValueField = "CategoryID";
            ddlkategori.DataTextField = "KategoriAdi";          
            ddlkategori.DataBind();
        }

         public void btnMakaleKaydet_Click(object sender, EventArgs e)
        {
            Guid UyeID = Guid.Parse("5619d081-3015-44d8-9b01-00ccf0e919de");
            MakaleController mc = new MakaleController();
            mc.Ekle(txtbaslik.Text,editor1.Value,Convert.ToInt32(ddlkategori.SelectedValue),UyeID);
        }
    }
}