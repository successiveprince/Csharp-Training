using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1
            TryCatch.Call();

            // Question 3
            Delegates.MyMethod();   

            //Question 4
            GenericDelegate.Method(); 

            //Question 5
            CheckOutput.CallMethod1();
            CheckOutput.CallMethod2();

            //Question 6
            Async_Await.Method1();
            Async_Await.Method2();

            Console.ReadKey();
        }
    }
}
