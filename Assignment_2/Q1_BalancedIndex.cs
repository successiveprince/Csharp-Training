using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Q1_BalancedIndex
    {
        public static int Find(int[] array)
        {
            //find PrefixSum
            int[] prefixSum = new int[array.Length];
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                prefixSum[i] = sum;
            }
            int n = prefixSum.Length;
            //for 0th index
            if(prefixSum[n-1] - prefixSum[0] == 0)
            {
                return 0;
            }
            //for mid index
            for(int i = 1; i < n-1; i++)
            {
                if(prefixSum[i-1] == prefixSum[n-1]-prefixSum[i])
                {
                    return i;
                }
            }
            //for last index
            if(prefixSum[n-2] == 0)
            {
                return (n - 1);
            }
            return -1;
        }
         public static void BalancedIndex()
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
            
            Console.WriteLine("\nBalanced Index is {0}" , Find(array));
        }
    }
}
