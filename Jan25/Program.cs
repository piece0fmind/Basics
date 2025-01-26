
using BasicExamples.Jan26;
using Jan25;

//ExecuteJan25();
ExecuteJan26();

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
    Arrays.Print();
}

