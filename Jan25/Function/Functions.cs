using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan25
{
    public class Functions
    {
        public static void AddInputNumbers(int a, int b) // takes parameters but doesn't return
        {
            int sum = a + b;
            Console.WriteLine($"The sum of {a} and {b} is {sum}");
        }
        public static void AddNumbers() // doesn't take parameters and doesn't return
        {
            int a = 10;
            int b = 20;
            int sum = a + b;
            Console.WriteLine($"The sum of {a} and {b} is {sum}");
        }

        public static int AddAndReturn() // doesn't take parameters but returns
        {
            int a = 10;
            int b = 20;
            int sum = a + b;
            return sum;
        }
        public static int AddInputAndReturn(int a, int b) // takes parameters and returns 
        {
            int sum = a + b;
            return sum;
        }
    }
}
