using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Extension
{
    public static class Helper
    {
        public static void ListControlDoldur<Entity>(ListControl control, List<Entity>list, string text, string value)     
        {
            control.DataSource = list;     //dataların içini doldurması için jenerik bir kontrlumuz var metot
            control.DataTextField = text;
            control.DataValueField = value;
            control.DataBind();
        }

        public static void MesajGoster(Page targetPage, string message)   //helper classı oluturduk hatalı yerlerde mesajımızı gösterecek
        {
            Literal ltr = new Literal();
            ltr.Text = "<script>alert('" + message + "') </script>";
            targetPage.Header.Controls.Add(ltr);
        }
    }
}
