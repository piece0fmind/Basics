using EFConsole.DbConnection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole.DbConnection
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "User ID=postgres;Password=root;Host=localhost;Port=5432;Database=bank_db;";

        // we need to define db set in order to create tables from the c# class models
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(ConnectionString);
        }
    }
}
