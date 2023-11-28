using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Question 1
    //        //TryCatch.Call();

    //        //// Question 3
    //        //Delegates.MyMethod();   

    //        ////Question 4
    //        //GenericDelegate.Method(); 

    //        ////Question 5
    //        //CheckOutput.CallMethod1();
    //        //CheckOutput.CallMethod2();

    //        //Question 6
    //        //Async_Await.Method1();
    //        //Async_Await.Method2();


    //        Console.ReadKey();
    //    }
    //}
    class Program
    {
        static void Main(string[] args)
        {
            callMethod();
            Console.ReadKey();
        }

        public static async void callMethod()
        {
            Task<int> task = Method1();
            Method2();
            int count = await task;
            Method3(count);
        }

        public static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    
                    count += 1;
                }
                Task.Delay(100).Wait(1000);
            });
            return count;
        }

        public static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine(" Method 2");
            }
        }

        public static void Method3(int count)
        {
            Console.WriteLine("Total count is " + count);
        }
    }
}
