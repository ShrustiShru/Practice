using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeedb.DataClasses
{
    public interface IDataClasses
    {
        void AddNewEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
        List<Employee> GetAllEmployee();
        List<Department> GetAllDepartment();
    }
}
