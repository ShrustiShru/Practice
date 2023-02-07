using CustomerLib.DataComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CustomerLoginPage.Controllers
{
    [AllowAnonymous]
    public class CustomerLoginController : Controller
    {
        // GET: CustomerLogin
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            var com = new CustomerRepo();
            try
            {
                var cst=com.ValidateCustomer(email, password);
                Session["CurrentCustomer"] = cst;
                FormsAuthentication.SetAuthCookie(cst.CustomerEmail, false);
                FormsAuthentication.RedirectFromLoginPage(cst.CustomerEmail, false);
                return View();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Login Error", ex.Message);
                return View();
            }
        }
    }
}