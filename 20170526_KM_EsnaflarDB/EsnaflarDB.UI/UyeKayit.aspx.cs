using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EsnaflarDB.BLL;
using Extension;
using System.Web.Security;
using EsnaflarDB.DTO;
using EsnaflarDB.BLL.DtoController;
using EsnaflarDB.Entity;


namespace EsnaflarDB.UI
{
    public partial class UyeKayit : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.MaintainScrollPositionOnPostBack = true;
            if (!IsPostBack)
            {
                SehirYukle();
            }
        }

        protected void SehirYukle()   //ddlsehire sehir yükledik
        {
            SehirController sehirc = new SehirController();
            Sehir sehir = new Sehir();

            ddlSehir.Items.Clear();
            ddlSehir.DataSource = sehirc.SehirGetir();
            ddlSehir.DataTextField = "SehirAdi";
            ddlSehir.DataValueField = "SehirID";
            ddlSehir.DataBind();

            ddlSehir.Items.Insert(0, new ListItem("Lütfen Sehir Giriniz", "0"));
        }

        protected void IlceYukle()   //sehire göre ilce yükledik
        {
            IlceController ilcec = new IlceController();
            Ilce ilce = new Ilce();

            ddlIlce.Items.Clear();
            int sehirID = Convert.ToInt32(ddlSehir.SelectedValue);
            ddlIlce.DataSource = ilcec.IlceGetir(sehirID);
            ddlIlce.DataTextField = "IlceAdi";
            ddlIlce.DataValueField = "SehirID";
            ddlIlce.DataBind();

            ddlSehir.Items.Insert(0, new ListItem("Lütfen İlçe Giriniz", "0"));
        }
        protected void ddlSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            IlceYukle();
        }

        protected void btnKaydet_Click(object sender, EventArgs e)
        {
            Kaydet();
        }

        private void Kaydet()    //kaydet metodu oluşturduk her bir textboxa ait olduğu verileri kaydedicek
        {
                
                UyeKisiselController ukc = new UyeKisiselController();
                Guid UyeID = Guid.NewGuid();
                ukc.Ekle(UyeID, txtAd.Text, txtSoyad.Text, rdbBay.Checked, Convert.ToDateTime(txtDogumTarihi.Text), txtTelefon.Text, txtAdres.Text, Convert.ToInt32(ddlIlce.SelectedValue));
                Helper.MesajGoster(this, "Kaydedildi!");
                temizle(this);
                
        }

       
            private void temizle(Control control)   //temizle metodu oluşturduk buton click olayında textboxlar temizlenecek
           {
                var textbox = control as TextBox;
                if (textbox != null)
                    textbox.Text = string.Empty;
               
                var dropDownList = control as DropDownList;
                if (dropDownList != null)
                    dropDownList.SelectedIndex = 0;
              
                var checkBox = control as CheckBox;
                if (checkBox != null)
                    checkBox.Checked = false;
              
                var radioButton = control as RadioButton;
                if (radioButton != null)
                    radioButton.Checked = false;

                foreach (Control kontrol in control.Controls)
                {
                    temizle(kontrol);
                }
          
            }
           
      }
        
  }
