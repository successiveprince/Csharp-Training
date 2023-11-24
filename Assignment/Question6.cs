//Question 6 -> Write a program to implement Async await with proper justification. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment
{
    class Async_Await
    {
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(" Method 1, thread = {0}", Thread.CurrentThread.ManagedThreadId);

                    Task.Delay(100);
                }
            });
        }
        public static void Method2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(" Method 2, thread = {0}", Thread.CurrentThread.ManagedThreadId);

                Task.Delay(100);
            }
        }
    }
}
