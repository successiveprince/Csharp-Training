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

            var name = names.Where(x => x.Contains('a'));                      // LINQ Method Syntax

            Console.WriteLine("--------------LINQ---------------\n");

            Console.WriteLine("LINQ Method Syntax");
            
            Console.WriteLine("Names with letter \'a\' :");
            foreach (var i in name)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("\nLINQ Query Syntax");
            var ans = from n in names where n.Contains('a') select n;          // LINQ Query Syntax
            foreach (var i in name)
            {
                Console.WriteLine(i);
            }

            int[] marks = { 23, 12, 43, 32, 23 };                              // Direct use of Aggregate Functions
            Console.WriteLine("\nMax marks : " + marks.Max());
            Console.WriteLine("Min marks : " + marks.Min());
            Console.WriteLine("Average marks : " + marks.Average());
            Console.WriteLine("Sum of marks : " + marks.Sum());
            Console.WriteLine("Count : " + marks.Count());



            MyClass.Method();                                               // Aggregate Functions in LINQ


            Console.ReadKey();
        }
    }
}
