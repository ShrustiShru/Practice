using CustomerLib.DataComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerLoginPage.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
           if (Session["CurrentCustomer"] != null)
            {
                var username = Session["CurrentCustomer"] as Customer;
                return $"Welcome {username.CustomerName}";
            }
            else
            {
                return $"Welcome Anonymous";
            }
        }
    }
}