using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welocme He Who Remains");

            //-----------Exception Handling-----------------
            ExceptionHandling A = new ExceptionHandling();

            //  A.MyDivByZeroException();
            //A.MyNullReferenceException();
            // A.MyIndexOutOfRangeException();         
            // A.MyFormatException();

            // A.CheckMarks();


            //-------------Deligates------------------
            MyDelegates.Method();

           // GenericDelegate.Method();

            Console.ReadKey();
        }
    }
}
