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
    public partial class AddStops : System.Web.UI.Page
    {
        TransportRepo repo = new TransportRepo();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtRoute.DataSource = repo.GetAllRoutes();
                txtRoute.DataTextField = "RouteName1";
                txtRoute.DataValueField = "RouteNumber";
                txtRoute.DataBind();
                txtRoute.Items.Insert(0, new ListItem
                {
                    Text = "Select the Route"
                });
            }
        }

        protected void btnAddStop_Click(object sender, EventArgs e)
        {
            RouteStop stop = new RouteStop
            {
                RouteNumber=100,
                PickUp = txtboxPick.Text,
                DropOut = txtboxDrop.Text,
                TicketAmount = decimal.Parse(txtboxPrice.Text)
            };
            repo.AddNewStops(stop);
            lblStop.Text = "Stops Added Successfully";
        }
    }
}