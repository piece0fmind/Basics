
using BasicExamples.Feb9;
using BasicExamples.Jan26;
using Jan25;
using System.Runtime.CompilerServices;

//ExecuteJan25();
//ExecuteJan26();
ExecuteFeb9();

void ExecuteJan25()
{
    Console.WriteLine("Input 2 numbers to add:");

    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Calling AddInputNumbers");
    Functions.AddInputNumbers(a, b);

    Console.WriteLine("Calling AddNumbers");
    Functions.AddNumbers();
    Console.WriteLine("Calling AddInputAndReturn");
    int sum = Functions.AddInputAndReturn(a, b);
    Console.WriteLine($"The sum of {a} and {b} is {sum}");


}

void ExecuteJan26()
{
    Console.WriteLine("Print an array");
    int[] array = new int[5]; // length of array is necessary while creating
    Console.WriteLine("Enter 5 numbers:");
    for (int i = 0; i < 5; i++)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;
    }
    Arrays.Print(array);

    Console.WriteLine("Counting length of the array");
    int length = Arrays.CalculateLength(array);
    Console.WriteLine($"The length of the array is {length}");

    Console.WriteLine("Finding the max number in the array");
    int max = Arrays.FindMax(array);
    Console.WriteLine($"The max number in the array is {max}");
}

void ExecuteFeb9()
{
    // Simple CRUD application with plain C# classes and list as data store.
    DataStore dataStore = new DataStore();
    
    while (true)
    {
        Console.WriteLine("\nChoose an option below:");
        Console.WriteLine("C - Create a new employee");
        Console.WriteLine("R - View employee by code");
        Console.WriteLine("U - Update an employee");
        Console.WriteLine("D - Delete an employee");
        Console.WriteLine("V - View all employees");
        Console.WriteLine("X - Exit");
        Console.Write("Your choice: ");
        char option = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        switch (option)
        {
            case 'C':
                Employee newEmployee = UserInputHelper.GetEmployeeDetails();
                dataStore.Add(newEmployee);
                break;

            case 'R':
                Console.Write("Enter Employee Code to view: ");
                int code = Convert.ToInt32(Console.ReadLine());
                Employee emp = dataStore.Get(code);
              
                Console.WriteLine($"Code: {emp.EmployeeCode}, Name: {emp.FirstName} {emp.LastName}, DOB: {emp.DateOfBirth:yyyy-MM-dd}");
                
                break;

            case 'U':
                Console.Write("Enter Employee Code to update: ");
                int updateCode = Convert.ToInt32(Console.ReadLine());
                Employee existingEmp = dataStore.Get(updateCode);
                
                Employee updatedEmp = new Employee();
                updatedEmp.EmployeeCode = updateCode;

                Console.Write("New First Name: ");
                updatedEmp.FirstName = Console.ReadLine();

                Console.Write("New Last Name: ");
                updatedEmp.LastName = Console.ReadLine();

                Console.Write("New Date Of Birth (yyyy-MM-dd): ");
               
                dataStore.Update(updateCode, updatedEmp);
                break;

            case 'D':
                Console.Write("Enter Employee Code to delete: ");
                int deleteCode = Convert.ToInt32(Console.ReadLine());
                dataStore.Delete(deleteCode);
                break;

            case 'V':
                Console.WriteLine("Employee List:");
                dataStore.ViewAll();
                break;

            case 'X':
                Console.WriteLine("Exiting program...");
                return;

            default:
                Console.WriteLine("Invalid option, please try again.");
                break;
        }
    }
}

