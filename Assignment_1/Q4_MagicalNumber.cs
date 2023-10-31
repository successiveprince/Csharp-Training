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
            string inputCopy = input;
            bool endProcess = false;
            int sum = 0;
            while (!endProcess)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    char ch = input[i];
                    int num = int.Parse(ch.ToString());
                    sum += num;
                }
                if (sum >= 10)
                {
                    input = sum.ToString();
                    sum = 0;
                }
                else
                {
                    endProcess = true;
                }
            }
            if (sum == 1)
                Console.WriteLine("{0} is a Magical Number.", inputCopy);
            else
                Console.WriteLine("{0} is not a Magical Number.", inputCopy);
        }
       
    }
}
