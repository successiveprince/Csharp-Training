using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Q4_MaxSubarray
    {
        public static void FindMaxSubarray(int [] array)
        {
            int maxi = int.MinValue;
            int sum = 0;

            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                maxi = Math.Max(sum, maxi);

                if (sum < 0)
                    sum = 0;
            }
            Console.WriteLine();
            Console.WriteLine("Maximum Subarray sum is {0}", maxi);
        }
        public static void MaxSubarray()
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

            FindMaxSubarray(array);
        }
    }
}
