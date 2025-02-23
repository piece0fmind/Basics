using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole.DbConnection.Models
{
    public class Department
    {
        public Guid Id { get; set; }    
        public string Name { get; set; }
        public string DepartmentCode { get; set; }
    }
}
