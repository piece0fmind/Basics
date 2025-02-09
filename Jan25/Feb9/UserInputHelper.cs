using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExamples.Feb9
{
    public static class UserInputHelper
    {
        public static Employee GetEmployeeDetails()
        {
            Employee employee = new Employee();

            Console.Write("First Name: ");
            employee.FirstName = Console.ReadLine();

            Console.Write("Last Name: ");
            employee.LastName = Console.ReadLine();

            Console.Write("Date Of Birth (yyyy-MM-dd): ");
            employee.DateOfBirth = DateTime.Parse(Console.ReadLine());

            return employee;
        }

    }
}
