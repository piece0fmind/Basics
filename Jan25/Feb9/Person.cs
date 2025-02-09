using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExamples.Feb9
{
    public class Employee : Person
    {
        public int EmployeeCode { get; set; }

    }
    public class Person
    {
        public string FirstName {  get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }

    }
}
