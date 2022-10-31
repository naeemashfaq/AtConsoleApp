using AtConsoleApp.DataContext;
using AtConsoleApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtConsoleApp.Services
{
    public class EmployeeService:IEmployeeService
    {
        private readonly EmployeeContext _context;

        public EmployeeService(EmployeeContext context)
        {
            _context = context;
        }
        public bool AddEmployee(Employee employee)
        {
            try
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<Employee> GetEmployees()
        {
            try
            {
                var empList = _context.Employees.ToList(); 
                return empList;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

    }
}
