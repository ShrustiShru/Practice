using Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebApplication
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application["Products"] = PhoneRepo.AllProducts;
        }
        protected void Session_Start(object sender, EventArgs e)
        {
            Session["myCart"] = new List<Product>();
            Session["recentItems"] = new Queue<Product>();
        }
    }
}