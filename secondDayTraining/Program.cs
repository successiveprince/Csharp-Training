using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondDayTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Enter your number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            var i = 1;
            var count = 0;
            while (i <= input)
            {
                if (input % i == 0)
                    count++;
                i++;
            }
            Console.WriteLine("Number of factors: {0}", count);*/

            /* Console.WriteLine("Enter your number: ");
             var input = Convert.ToInt32(Console.ReadLine());
             var i = 1;
             var count = 0;
             while (i <= input)
             {
                 if (input % i == 0)
                     count++;

                 i++;
             }
             if(count > 2)
                 Console.WriteLine("{0} is not a Prime Number" , input);
             else
             {
                 Console.WriteLine("{0} is a Prime Number", input);
             }*/
            Console.WriteLine("Enter your number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            for (var i = input; i >= 2; i--)
            {
                var count = 0;
                for (var j = 1; j <= i; j++)
                {
                    
                    if (i % j == 0)
                    {
                        count+=2;
                    }
                }
                if(count <= 2)
                {
                    Console.WriteLine("Nearest Prime is : {0}", i);
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
