using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Q6_ThirdLargest
    {

        public static void FindThirdLargestValue(int[] array)
        {
            int n = array.Length;

            int firstLargest = int.MinValue;
            int secondLargest = int.MinValue;
            int thirdLargest = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > firstLargest)
                {
                    thirdLargest = secondLargest;
                    secondLargest = firstLargest;
                    firstLargest = array[i];
                }
                else if (array[i] > secondLargest && array[i] < firstLargest)
                {
                    thirdLargest = secondLargest;
                    secondLargest = array[i];
                }
                else if (array[i] > thirdLargest && array[i] < secondLargest)
                {
                    thirdLargest = array[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Third largest value is {0}", thirdLargest);
        }

        public static void ThirdLargestValue()
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

            FindThirdLargestValue(array);
        }
    }
}
