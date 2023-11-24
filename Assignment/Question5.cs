//Question 5 -> Find output of the given code

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class CheckOutput
    {
        public static void CallMethod1()
        {
            Func<string, string> output = delegate (string name)
            {
                return "Hello " + name;
            };
            Console.Write(output("James\n"));
        }
        public static void CallMethod2()
        {
            Action<int> output = i => Console.Write(i);
            output(10);
        }
    }
}
