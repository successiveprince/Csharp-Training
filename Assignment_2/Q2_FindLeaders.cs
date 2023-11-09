using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Q2_FindLeaders
    {
        public static void FindNumberOfLeaders(int[] array)
        {
            int maxi = int.MinValue;
            int count = 0;

            for(int i = array.Length - 1; i >= 0; i--)
            {
                if(array[i] > maxi)
                {
                    count++;
                    maxi = array[i];
                }
            }
            Console.WriteLine("\nNumber of Leaders: {0}", count);
        }
        public static void FindLeaders()
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
            FindNumberOfLeaders(array);
        }
    }
}
