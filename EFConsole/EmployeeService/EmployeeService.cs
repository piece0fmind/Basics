using System;
using System.Collections.Generic;
using System.Linq;
using EFConsole.DbConnection;
using EFConsole.DbConnection.Models;
using Microsoft.EntityFrameworkCore;

public class EmployeeService
{
    private readonly AppDbContext _appDbContext;

    public EmployeeService(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    /// <summary>
    /// Create a new Employee
    /// </summary>
    public void CreateEmployee(Employee employee)
    {
        // db context has methods for crud operations
        employee.DateOfBirth = DateTime.SpecifyKind(employee.DateOfBirth, DateTimeKind.Utc);
        _appDbContext.Employees.Add(employee);
        _appDbContext.SaveChanges();
    }

    /// <summary>
    /// Get All Employees
    /// </summary>
    public List<Employee> GetAllEmployees()
    {
        return _appDbContext.Employees.ToList();
    }

    /// <summary>
    /// Get Employee By ID
    /// </summary>
    public Employee? GetEmployeeById(int id)
    {
        return _appDbContext.Employees.Find(id);
    }

    /// <summary>
    /// Update an Existing Employee
    /// </summary>
    public bool UpdateEmployee(Employee employee)
    {
        var existingEmployee = _appDbContext.Employees.Find(employee.Id);
        if (existingEmployee == null)
            return false;

        existingEmployee.FirstName = employee.FirstName;
        existingEmployee.DepartmentId = employee.DepartmentId;

        _appDbContext.SaveChanges();
        return true;
    }

    /// <summary>
    /// Delete Employee By ID
    /// </summary>
    public bool DeleteEmployee(int id)
    {
        var employee = _appDbContext.Employees.Find(id);
        if (employee == null)
            return false;

        _appDbContext.Employees.Remove(employee);
        _appDbContext.SaveChanges();
        return true;
    }
}
