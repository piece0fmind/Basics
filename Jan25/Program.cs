
using BasicExamples.Jan26;
using Jan25;

ExecuteJan25();


void ExecuteJan25()
{
    Console.WriteLine("Input 2 numbers to add:");

    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Calling AddInputNumbers");
    Functions.AddInputNumbers(a, b);


    Console.WriteLine("Calling AddNumbers");
    int sums = Functions.AddAndReturn();
    Console.WriteLine($"The sum is: {sums}");



    Console.WriteLine("Calling AddInputAndReturn");
    int sum = Functions.AddInputAndReturn(a, b);
    Console.WriteLine($"The sum of {a} and {b} is {sum}");


}

//ExecuteJan26();
//void ExecuteJan26()
//{
//    Console.WriteLine("Print an array");
//    int[] array = new int[5]; // length of array is necessary while creating
//    Console.WriteLine("Enter 5 numbers:");
//    for (int i = 0; i < 5; i++)
//    {
//        int number = Convert.ToInt32(Console.ReadLine());
//        array[i] = number;
//    }
//    Arrays.Print(array);

//    Console.WriteLine("Counting length of the array");
//    int length = Arrays.CalculateLength(array);
//    Console.WriteLine($"The length of the array is {length}");

//    Console.WriteLine("Finding the max number in the array");
//    int max = Arrays.FindMax(array);
//    Console.WriteLine($"The max number in the array is {max}");
//}

