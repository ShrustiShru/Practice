using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TransportLib.DataBase;

namespace TransportFrontEnd.WebForms
{
    public partial class DisplayEmployees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var list = Application["SamsungEmployee"] as List<SamsungEmployee>;
                lstEmployee.DataSource = Application["SamsungEmployee"] as List<SamsungEmployee>;
                lstEmployee.DataBind();
            }
        }
    }
}