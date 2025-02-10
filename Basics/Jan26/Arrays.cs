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
            /*for (int i = 0; i < 5; i++) // we can do this using both of these loops
            {
                count++;
            }*/
            foreach (int i in array)
            {
                count++;
            }
            return count;
        }

        public static int FindMax(int[] array)
        {   int max = array[0]; //assume the first number is the max
            for(int i = 0;i < 5; i++)
            {
                if (array[i] > max)
                {
                    max = array[i]; // if array[i] is greater than max then assign max = array[i];
                }
            }
            return max;
        }
    }
}
