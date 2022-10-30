using AtConsoleApp.Entities;
using AtConsoleApp.Services;
using AtClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtConsoleApp.Handler
{
    public class ApplicationHandler
    {
        private readonly IEmployeeService _empService;
        Employee emp = new Employee();
        List<Employee> empList = new List<Employee>();
        public ApplicationHandler(IEmployeeService empService)
        {
            _empService = empService;
        }
        public void Run()
        {
            
            Console.Write("Enter the First Input: ");
            var input1 = Console.ReadLine();
            while(input1 == null || input1==string.Empty)
            {
                Console.Write("Enter the First Input: ");
                input1 = Console.ReadLine();
            }
            
            
            Console.Write("Enter the Second Input: ");
            var input2 = Console.ReadLine();
            while (input2 == null || input2 == string.Empty)
            {
                Console.Write("Enter the Second Input: ");
                input2 = Console.ReadLine();
            }
            int option = 0;
            do
            {
                Console.WriteLine("\nWhat do you want to do? ");
                Console.WriteLine("Press 1 for to add two inputs");
                Console.WriteLine("Press 2 for save to database");
                Console.Write("Press 3 for displaying employee data: ");
                option = Convert.ToInt32(Console.ReadLine());
            }
            while (option > 3 || option < 1);
            
            switch(option)
            {
                case 1:
                    AddInputs(input1, input2);
                    break;
                case 2:
                    CreateEmpData(input1, input2);
                    break;
                case 3:
                    
                    PrintEmpData();
                    break;
            }
            if (option == 1)
            {
                

            }
            else if (option == 2)
            {
                

            }
            else if (option == 3)
            {
                
            }
           
            

        }

        public void PrintEmpData()
        {
            empList = (List<Employee>)_empService.GetEmployees();
            if (empList == null || empList.Count == 0)
            {
                Console.WriteLine("No Record to display");
            }
            else
            {
                Console.WriteLine("\n------------------------------");
                Console.WriteLine("First Name   " + "Last Name");
                Console.WriteLine("------------------------------");
                foreach (var item in empList)
                {

                    Console.WriteLine(item.FirstName + "\t\t" + item.LastName);
                }
            }
            
        }

        public void CreateEmpData(string fName, string lName)
        {
            emp.FirstName = fName;
            emp.LastName = lName;
            bool res = _empService.AddEmp(emp);
            if (res == true)
            {
                Console.WriteLine("\n Record added successfully");
            }
            else
            {
                Console.WriteLine("\n Problem in adding the record");
            }
        }

        public void AddInputs (string input1, string input2)
        {
            float mydec1, mydec2;
            int num1, num2;
            if ( float.TryParse(input1, out mydec1) && float.TryParse(input2, out mydec2))
            {
                var result = mydec1.Add(mydec2);
                Console.WriteLine("The result dec is: " + result);
            }
            else if (int.TryParse(input1, out num1) && int.TryParse(input2, out num2))
            {

                var result = num1.Add(num2);
                Console.WriteLine("The result int is: " + result);
            }
            else
            {
                var result = input1.Add(input2);
                Console.WriteLine("The string is: " + result);
            }
        }
    }
}
