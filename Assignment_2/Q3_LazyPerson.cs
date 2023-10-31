using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Q3_LazyPerson
    {
        public static void Find(int[] array)
        {
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == 1)
                    continue;
                else
                {
                    for(int j = i+1;j<array.Length;j++)
                    {
                        if (array[j] == 0)
                            array[j] = 1;
                        else
                            array[j] = 0;
                    }
                }
                count++;
            }
            Console.WriteLine();
            Console.WriteLine("Minimun Number of Switch a person press : {0}", count);
        }
        public static void LazyPerson()
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

            Find(array);
        }
    }
}
