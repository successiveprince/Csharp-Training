using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Q3_FindPairs
    {
        public static void ShowPairs(int[] array, int size, int targetSum)
        {
            Console.WriteLine("Pairs with sum less than " + targetSum + ":");

            for (int i = 0; i < size - 1; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] + array[j] < targetSum)
                    {
                        Console.WriteLine("[{0},{1}] with indices ({2},{3})", array[i], array[j], i, j);
                    }
                }
            }
        }

        public static void FindPairs()
        {
            int size;
            Console.Write("Enter the size of array : ");
            size = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write(String.Format("Enter element at index {0} : ", i));
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nArray is : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            int target;
            Console.Write("\n\nEnter your target value : ");
            target = Convert.ToInt32(Console.ReadLine());

            ShowPairs(array, size, target);
        }
        
    }
}
