using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicExamples.Jan26
{
    public class Arrays
    {
        public static void Print(int[] array)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Array member at index {i} = {array[i]}");
                //array[6] = i; // This will give error because that array can hold only 5 numbers.
            }
            
        }
        public static int CalculateLength(int[] array)
        {
            int count = 0;
            foreach(int i in array)
            {
                count++;
            }
            return count;
        }
    }
}
