//Question 1 -> Write a small program where you need to implement a Try and Catch Block.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class TryCatch
    {
        public static void Call()
        {
            int input;
            Console.WriteLine("Enter your number");
            input = Convert.ToInt32(Console.ReadLine());

            try
            {
                for (int div = 0; div < 5; div++)
                {
                    Console.WriteLine(input / div);
                }
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int div = 1; div < 5; div++)
                {
                    Console.WriteLine("{0} divided by {1} :{2} ", input, div, input / div);
                }
            }
        }
    }
}