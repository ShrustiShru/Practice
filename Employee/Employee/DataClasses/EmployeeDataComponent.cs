using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeedb.DataClasses
{
    public class EmployeeDataComponent : IDataClasses
    {
        static EmployeeEntities emp = new EmployeeEntities();

        public void AddNewEmployee(Employee employee)
        {
            emp.Employees.Add(employee);
            emp.SaveChanges();
        }

        public void DeleteEmployee(int id)
        {
            var found = emp.Employees.FirstOrDefault((p) => p.EmployeeId == id);
            emp.Employees.Remove(found);
            emp.SaveChanges();
        }

        public List<Department> GetAllDepartment()
        {
            return emp.Departments.ToList();
        }

        public void UpdateEmployee(Employee employee)
        {
            var found = emp.Employees.FirstOrDefault((p) => p.EmployeeId == employee.EmployeeId);
            if (found != null)
            {
                found.EmployeeId = employee.EmployeeId;
                found.EmployeeName = employee.EmployeeName;
                found.EmployeeSalary = employee.EmployeeSalary;
                found.EmployeeAddress = employee.EmployeeAddress;
            }
            emp.SaveChanges();
        }

        List<Employee> IDataClasses.GetAllEmployee()
        {
            throw new NotImplementedException();
        }
    }
}
