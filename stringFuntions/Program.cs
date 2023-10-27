using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringFuntions
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Prince Kumar";
            string company = "Successive Digital";

            //concat with +
            Console.WriteLine(name + company);

            //String Format
            string st = string.Format("My name is {0}.My company name is {1}.", name, company);
            Console.WriteLine(st);
            Console.WriteLine("My name is {0}.My company name is {1}.", name, company);
            
            //String Length
            Console.WriteLine("Length of name is "+ name.Length);

            //Concat
            Console.WriteLine(string.Concat(name, company));


            //---String Builder

            StringBuilder sb = new StringBuilder();

            //Append
            sb.Append("Maxx");
            sb.Append(" Tenison");
            Console.WriteLine(sb);

            //Format
            Console.WriteLine("My name is {0}.", sb);

            //Insert
            Console.WriteLine(sb.Insert(4, " C#"));

            //Retrieve a string from StringBuilder object
            string s = sb.ToString();
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
