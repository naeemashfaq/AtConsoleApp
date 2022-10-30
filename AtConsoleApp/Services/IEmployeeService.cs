using AtConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtConsoleApp.Services
{
    public interface IEmployeeService
    {
        bool AddEmp(Employee employee);
       public IEnumerable<Employee> GetEmployees();
    }
}
