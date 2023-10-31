using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Q4_MagicalNumber
    {

        public static void CheckMagicalNumber()
        {
            string input;
            Console.WriteLine("Enter Your Number: ");
            input = Console.ReadLine();
            StringBuilder sb = new StringBuilder(input);
            
            bool endProcess = false;
            int sum = 0;

            while (!endProcess)
            {
                for (int i = 0; i < sb.Length; i++)
                {
                    int num = sb[i] - '0';
                    sum += num;
                }
                if (sum >= 10)
                {
                    sb.Clear();
                    sb.Append(sum.ToString());
                    sum = 0;
                }
                else
                {
                    endProcess = true;
                }
            }
            if (sum == 1)
                Console.WriteLine("{0} is a Magical Number.", input);
            else
                Console.WriteLine("{0} is not a Magical Number.", input);
        }
       
    }
}
