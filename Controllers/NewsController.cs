using NewsApp.Data_Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsApp.Controllers
{
    public class NewsController : Controller
    {
        static bool signin = false;

        static New obj = new New();

        static NewsRepo repo = new NewsRepo();

        public ActionResult Index()
        {
            var model = new NewsRepo().GetAllNews();
            return View();
        }

        [HttpPost]
        public ActionResult SignIn()
        {
            string mail = Request.Form["txtEmail"];
            string pass = Request.Form["txtPassword"];
            var email = "shrusti@gmail.com";
            var password = "Shrusti";
            if (mail==email && pass==password)
            {
                signin = true;
                return RedirectToAction("Home");
            }
            else
            {
                TempData["error"] = "Invalid Username or Password";
                return RedirectToAction("Index");
            }
        }

        public ActionResult Home()
        {
            if (signin!= true)
                return RedirectToAction("SignIn");
            TempData["Copyrights"] = "Aravind";
            return View(repo.GetAllNews());
        }

        public ActionResult Add()
        {
            return View(new New());
        }

        [HttpPost]
        public ActionResult Add(New add)
        {
            repo.AddNews(add);
            return RedirectToAction("Home");
        }
    }
}