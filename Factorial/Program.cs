using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        public static int FindFactorial(int input)
        {
            if (input == 0 || input == 1)
                return 1;
            int fac;
            fac = input * FindFactorial(input - 1);
            return fac;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial Program using Recursion\n");
            Console.Write("Enter the number: ");
            string s =Console.ReadLine();
            int input;
            bool res = int.TryParse(s, out input);
            if (res && input > 0)
            {
                Console.WriteLine("Factorial of {0} is {1}", input, FindFactorial(input));
            }
            else
            {
                Console.WriteLine("Wrong Input!!!");
            }
            Console.ReadKey();
             
        }
    }
}
