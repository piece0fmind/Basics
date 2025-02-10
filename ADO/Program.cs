
using ADO;
using ADO.CRUD;

string connectionString = DbConfig.ConnectionString;

CrudOperator crud = new(connectionString);

//CreateNewEmployee();
ViewAllEmployees();

void CreateNewEmployee()
{
    Employee employee = new Employee();
    TakeInput(employee);
    crud.Insert(employee);
}
void ViewAllEmployees()
{
    
    crud.ViewAll();
}
void TakeInput(Employee employee)
{
    Console.WriteLine("Enter employee details below.");
    Console.Write("First Name: ");
    employee.FirstName = Console.ReadLine();
    Console.Write("Last Name: ");
    employee.LastName = Console.ReadLine();
    Console.Write("Birth Date: ");
    employee.DateOfBirth = DateTime.Parse(Console.ReadLine());
}