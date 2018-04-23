using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
 
    protected void ASPxCallback1_Callback(object source, DevExpress.Web.ASPxCallback.CallbackEventArgs e)
    {
        
        string[] param = e.Parameter.Split('|');
        int index = Convert.ToInt32(param[0]);

        
        //if (gridView.GetRowLevel(index) == 1)
        //    ASPxPopupMenu1.Items.FindByName("Item2").ClientEnabled = false;
        //else
        //    ASPxPopupMenu1.Items.FindByName("Item2").ClientEnabled = true;
        param[0] = gridView.GetRowLevel(index).ToString();

        e.Result = string.Format("{0}|{1}|{2}", param);//[0],param[1],param[2]
    }
}