using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class DbConfig
    {
        // This is a constant variable. Its value cannot be changed from other places.
        public const string ConnectionString = "User ID=postgres;Password=root;Host=localhost;Port=5432;Database=console-db;";
    }
}
