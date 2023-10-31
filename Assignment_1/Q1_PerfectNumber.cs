using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Q1_PerfectNumber
    {
        public static bool Find(int x)
        {
            if (x <= 0)
            {
                return false;
            }

            int sum = 0;
            for (int i = 1; i <= x / 2; i++)
            {
                if (x % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == x)
                return true;
            else
            {
                return false;
            }
        }
        public static void IsPerfect()
        {
            int input;
            Console.Write("Enter a Number : ");
            input = int.Parse(Console.ReadLine());

            if (Find(input))
            {
                Console.WriteLine(String.Format("{0} is a Perfect Number", input));
            }
            else
            {
                Console.WriteLine(String.Format("{0} is not a Perfect Number", input));
            }
        }
    }
}

