using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\nEnter Your Choice:");
                Console.WriteLine("1.Balanced Index\n2.Find Leaders\n3.Lazy Person\n4.Maximum Subarray\n5.Exit");
                var ch = Console.ReadLine();
                choice = int.Parse(ch);

                switch (choice)
                {
                    case 1:
                        Q1_BalancedIndex.BalancedIndex();
                        break;
                    case 2:
                        Q2_FindLeaders.FindLeaders();
                        break;
                    case 3:
                        Q3_LazyPerson.LazyPerson();
                        break;
                    case 4:
                        Q4_MaxSubarray.MaxSubarray();
                        break;
                    case 5:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Enter Correct Option!!!");
                        break;
                }
            }
            while (choice != 5);
            

            Console.ReadKey();
        }
    }
}
