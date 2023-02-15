using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TransportLib.DataBase;

namespace TransportFrontEnd.WebForms
{
    public partial class Routes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDisplayRoute_Click(object sender, EventArgs e)
        {
                var list = Application["Routes"] as List<RouteName>;
                lstRoutes.DataSource = Application["Routes"] as List<RouteName>;
                lstRoutes.DataBind();
        }
        
    }
}