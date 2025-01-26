using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExamples.Jan26
{
    public class Arrays
    {
        public static void Print()
        {
            int[] array = new int[5]; // length of array is necessary while creating
            Console.WriteLine("Enter 5 numbers:");
            for (int i = 0; i < 5; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
                array[i] = number;
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Array member at index {i} = {array[i]}");
                //array[6] = i; // This will give error because that array can hold only 5 numbers.
            }
        }
    }
}
