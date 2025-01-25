// See https://aka.ms/new-console-template for more information

using Jan25;

Console.WriteLine("Hello, World!");

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


void AddInputNumbers(int a, int b) // takes parameters but doesn't return
{
    int sum = a + b;
    Console.WriteLine($"The sum of {a} and {b} is {sum}");
}
void AddNumbers() // doesn't take parameters and doesn't return
{
    int a = 10;
    int b = 20;
    int sum = a + b;
    Console.WriteLine($"The sum of {a} and {b} is {sum}");
}

int AddAndReturn() // doesn't take parameters but returns
{
    int a = 10;
    int b = 20;
    int sum = a + b;
    return sum;
}
int AddInputAndReturn(int a, int b) // takes parameters and returns 
{
    int sum = a + b;
    return sum;
}

