using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TransportLib.Repo;

namespace TransportFrontEnd.WebForms
{
    public partial class BookTicket : System.Web.UI.Page
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
            }
        }
        

        protected void txtRoute_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = txtRoute.SelectedValue;
            txtPick.DataSource = repo.GetAllStops(int.Parse(selected));
            txtPick.DataTextField = "PickUp";
            txtPick.DataBind();
        }

        protected void txtPick_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = txtRoute.SelectedValue;
            txtDrop.DataSource = repo.GetAllStops(int.Parse(selected));
            txtDrop.DataTextField = "DropOut";
            
            txtDrop.DataValueField = "TicketAmount";
            txtDrop.DataBind();
        }

        protected void txtDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            var selected = txtDrop.SelectedValue;
            lblBook.Text = repo.getFair(txtPick.DataTextField, txtDrop.DataTextField, int.Parse(txtRoute.SelectedValue)).TicketAmount.ToString();
            lblBook.DataBind();
        }

        protected void btnBook_Click(object sender, EventArgs e)
        {

        }
    }
}