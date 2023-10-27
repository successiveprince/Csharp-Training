using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            double principal;
            float rate;
            float year;

            Console.WriteLine("Enter Principal: ");
            var input1 = Console.ReadLine();
            if (double.TryParse(input1, out principal))
            {
                Console.WriteLine("Enter Rate of Interest: ");
                var input2 = Console.ReadLine();
                if (float.TryParse(input2, out rate))
                {
                    Console.WriteLine("Enter Year: ");
                    var input3 = Console.ReadLine();
                    if (float.TryParse(input3, out year))
                    {
                        double si = (principal * rate * year) / 100;
                        Console.WriteLine("Your Simple Interest is {0}", si);
                        Console.WriteLine("Total Amount is {0}", principal + si);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Please enter correct year!!!");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Please enter correct Rate of Interest!!!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Please enter correct Principal!!!");
                Console.ReadLine();
            }

        }
    }
}
