using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {

        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\nEnter Your Choice:");
                Console.WriteLine("1.Perfect Number\n2.Minimum Gap\n3.Find Pairs Sum\n4.Magical Number\n5.Remove Spaces\n" +
                    "6.Third Largest Number\n7.Product Array\n8.Exit");
                var ch = Console.ReadLine();
                choice = int.Parse(ch);

                switch (choice)
                {
                    case 1:
                        Q1_PerfectNumber.IsPerfect();
                        break;
                    case 2:
                        Q2_MinimumGap.FindMinimumGap();
                        break;
                    case 3:
                        Q3_FindPairs.FindPairs();
                        break;
                    case 4:
                        Q4_MagicalNumber.CheckMagicalNumber();
                        break;
                    case 5:
                        Q5_RemoveSpaces.RemoveSpaces();
                        break;
                    case 6:
                        Q6_ThirdLargest.ThirdLargestValue();
                        break;
                    case 7:
                        Q7_ProductArray.ProductArray();
                        break;
                    case 8:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Enter Correct Option!!!");
                        break;
                }
            }
            while (choice != 8);

            Console.ReadKey();
        }
    }
}

