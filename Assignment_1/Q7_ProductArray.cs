using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Q7_ProductArray
    {
        public static void FindProductArray(int[] array)
        {
            int n = array.Length;
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                int product = 1;
                for (int j = 0; j < n; j++)
                {
                    if (i != j)
                    {
                        product = product * array[j];
                    }

                }
                result[i] = product;
            }
            Console.WriteLine("\nArray after product is : ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("{0} ", result[i]);
            }
        }
        public static void ProductArray()
        {
            int size;
            Console.Write("Enter the size of array : ");
            size = Convert.ToInt32(Console.ReadLine());
            if (size <= 2)
            {
                Console.WriteLine("Invalid Input!!!");
                return;
            }

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
            FindProductArray(array);
        }
       
    }
}
