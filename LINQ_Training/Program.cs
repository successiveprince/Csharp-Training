using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Training
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Prince", "Ajay", "Yash", "Govind", "Utkarsh", "Akshat" };

            var name = names.Where(x => x.Contains('a'));

            Console.WriteLine("LINQ");
            Console.WriteLine("Names with letter \'a\' :");
            foreach (var i in name)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
