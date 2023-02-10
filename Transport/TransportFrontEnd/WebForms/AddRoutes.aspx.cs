using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TransportLib.DataBase;
using TransportLib.Repo;

namespace TransportFrontEnd.WebForms
{
    public partial class AddRoutes : System.Web.UI.Page
    {
        TransportRepo repo = new TransportRepo();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            RouteName route = new RouteName
            {
                RouteName1 = $"{txtInitial.Text} - {txtFinal.Text}"
            };
            repo.AddNewRoute(route);
            lblSuccess.Text = "Route Added Successfully";
        }
    }
}