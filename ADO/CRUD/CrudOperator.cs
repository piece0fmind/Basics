using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.CRUD
{
    public class CrudOperator
    {
        private readonly string _connectionString;
        public CrudOperator(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Insert(Employee employee)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                var newEmployeeCode = GetMaxEmployeeCode(connection);

                string query = @"Insert into Employee (FirstName, LastName, DateOfBirth, EmployeeCode) 
                                values (@firstName, @lastName, @dateOfBirth, @employeeCode);";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@firstName", employee.FirstName.Trim());
                    command.Parameters.AddWithValue("@lastName", employee.LastName.Trim());
                    command.Parameters.AddWithValue("@dateOfBirth", employee.DateOfBirth);
                    command.Parameters.AddWithValue("@employeeCode", newEmployeeCode);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Employee created");
                }
            }
        }
        public void Update(int id, Employee employee)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"UPDATE Employee 
                         SET FirstName = @firstName, 
                             LastName = @lastName, 
                             DateOfBirth = @dateOfBirth, 
                             EmployeeCode = @employeeCode 
                         WHERE EmployeeId = @id;"; 

                using (var command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@firstName", employee.FirstName.Trim());
                    command.Parameters.AddWithValue("@lastName", employee.LastName.Trim());
                    command.Parameters.AddWithValue("@dateOfBirth", employee.DateOfBirth);
                    command.Parameters.AddWithValue("@employeeCode", employee.EmployeeCode); 

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Employee updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("No employee found with the given ID.");
                    }
                }
            }
        }

        public void GetById(int id)
        {

        }
        public void Delete(int id)
        {

        }
        public void ViewAll()
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();

                string query = @"SELECT FirstName, LastName, DateOfBirth, EmployeeCode FROM Employee;";
                using (var command = new NpgsqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        Console.WriteLine("Employees List:");
                        Console.WriteLine("---------------------------------------------------");

                        while (reader.Read()) 
                        {
                            string firstName = reader.GetString(0);
                            string lastName = reader.GetString(1);
                            DateTime dateOfBirth = reader.GetDateTime(2);
                            int employeeCode = reader.GetInt32(3);

                            Console.WriteLine($"Name: {firstName} {lastName}, DOB: {dateOfBirth:yyyy-MM-dd}, Code: {employeeCode}");
                        }
                    }
                }
            }
        }
        private static int GetMaxEmployeeCode(NpgsqlConnection connection)
        {
            int newEmployeeCode = 1; 
            string maxQuery = "SELECT COALESCE(MAX(EmployeeCode), 0) + 1 FROM Employee";
            using (var maxCmd = new NpgsqlCommand(maxQuery, connection))
            {
                newEmployeeCode = Convert.ToInt32(maxCmd.ExecuteScalar());
            }
            return newEmployeeCode;
        }
    }
}
