using EmployeeLib.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private IDataClasses Employee = new EmployeeDataComponent();
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            ViewBag.Departments = Employee.GetAllDepartments();
            return PartialView(new Employee());
        }

        public ActionResult GetAllEmployees()
        {
            var model = Employee.GetAllEmployees();
            return PartialView(model);
        }
        [HttpPost]
        public ActionResult Add(Employee employee, string DepartmentName)
        {
            employee.EmployeeDepartment = int.Parse(DepartmentName);
            Employee.AddNewEmployee(employee);
            return RedirectToAction("Index");
        }

        public ActionResult Remove(string id)
        {
            if(id != null)
            {
                Employee.DeleteEmployee(Convert.ToInt32(id));
                return RedirectToAction("Index");
            }
            else return RedirectToAction("Index");
        }

        public ActionResult Update(string id)
        {
            if (id != null)
            {
                var data = Employee.GetAllEmployees();
                var found = data.Find((e) => e.EmployeeId == Convert.ToInt32(id));
                ViewBag.Departments = Employee.GetAllDepartments();
                return PartialView(found);
            }
            else return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Update(Employee employee,string DepartmentName)
        {
            employee.EmployeeDepartment = int.Parse(DepartmentName);
            Employee.UpdateEmployee(employee);
            return RedirectToAction("Index");
        }
    }
}