using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole.DbConnection.Models
{
    public class Employee : Person
    {
        public Guid Id { get; set; }
        public int EmployeeCode { get; set; }
        public int PhoneNumber {  get; set; }
        [ForeignKey("Department")]
        public Guid DepartmentId { get; set; }

    }
    public class Person
    {
        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
