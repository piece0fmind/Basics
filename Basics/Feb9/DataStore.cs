using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExamples.Feb9
{
    public sealed class DataStore
    {
        private readonly List<Employee> employees = new();
        //private const string EmployeeCodePrefix = "XX_EMP_";

        public void Add(Employee employee)
        {
            int maxCode = 0;
            if(employees.Count != 0)
            {
                maxCode = employees.Max(x => x.EmployeeCode);
            }
            employee.EmployeeCode = maxCode + 1;
            employees.Add(employee);
        }
        public void Update(int employeeCode, Employee employee)
        {
            var existingEmployee = employees.FirstOrDefault(x => x.EmployeeCode == employeeCode);
            // Need to handle null case (ALWAYS CHECK FOR NULL AFTER FIRST OR DEFAULT)
            existingEmployee.FirstName = employee.FirstName;
            existingEmployee.LastName = employee.LastName;
            existingEmployee.DateOfBirth = employee.DateOfBirth;
        }
        public Employee Get(int employeeCode)
        {
            var employee = employees.FirstOrDefault(x => x.EmployeeCode == employeeCode);
            // Need to handle null case
            return employee;
        }
        public void  ViewAll()
        {
            foreach (var emp in employees)
            {
                Console.WriteLine($"Code: {emp.EmployeeCode}, Name: {emp.FirstName} {emp.LastName}, DOB: {emp.DateOfBirth:yyyy-MM-dd}");
            }
        }
        public void Delete(int employeeCode) 
        {
            var employee = employees.FirstOrDefault(x => x.EmployeeCode == employeeCode);
            // Need to handle null case
            employees.Remove(employee);
        }
    }
}
