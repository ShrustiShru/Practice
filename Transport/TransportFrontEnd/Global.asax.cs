using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using TransportLib.DataBase;
using TransportLib.Repo;

namespace TransportFrontEnd
{
    public class Global : System.Web.HttpApplication
    {
        TransportRepo repo = new TransportRepo();
        
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["SamsungEmployee"] = repo.GetAllEmployees();
            Application["Routes"] = repo.GetAllRoutes();
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["SamsungEmployee"] = new List<SamsungEmployee>();
        }
    }
}