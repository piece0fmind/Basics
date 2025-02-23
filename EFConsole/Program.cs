using EFConsole.DbConnection;
using EFConsole.DbConnection.Models;
using System;

class Program
{
    static void Main()
    {
        using var context = new AppDbContext(); // Create DbContext instance
        var employeeService = new EmployeeService(context); // Create EmployeeService instance

        // Creating a new Employee object
        var newEmployee = new Employee
        {
            Id = Guid.NewGuid(), // Generate a unique ID
            FirstName = "John",
            LastName = "Doe",
            DateOfBirth = new DateTime(1990, 5, 15),
            EmployeeCode = 1234,
            PhoneNumber = 987654321,
            DepartmentId = Guid.NewGuid() // Assuming a department exists
        };

        // Calling the CreateEmployee method
        employeeService.CreateEmployee(newEmployee);

        Console.WriteLine("Employee created successfully!");
    }
}
