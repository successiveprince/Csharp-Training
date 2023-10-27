using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoApp
{
    class demoApp
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello Prince");
             int age = 22;
             string name = "Prince Kumar";
             string company = "Successsive Digital";

             string user = string.Format("My name is {0}.My company name is {1}.My age is {2}", name, company, age);
             Console.WriteLine(user);
             Console.ReadLine();*/

            Console.WriteLine("Please enter your age: ");
            var input = Console.ReadLine();

            int age;

            if (int.TryParse(input, out age))
            {
                Console.WriteLine(string.Format("Your age is {0}", age));
            }
            else
            {
                Console.WriteLine("Wrong Input!!!");
            }

            Console.ReadKey();
        }
    }
}
