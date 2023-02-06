using Employeedb.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IDataClasses repo = new EmployeeDataComponent();

        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        //Add Employee//
        public ActionResult AddNew()
        {
            return View(new Employee());
        }

        [HttpPost]
        public ActionResult AddNew(Employee employee)
        {
            repo.AddNewEmployee(employee);
            return RedirectToAction("");
        }

        public ActionResult Update(int id)
        {
            var found = repo.GetAllEmployee().FirstOrDefault((p) => p.EmployeeId == id);
            return View(new Employee());
        }

        [HttpPost]
        public ActionResult Update(Employee employee)
        {
            repo.UpdateEmployee(employee);
            return RedirectToAction("");
        }

        public
    }
}