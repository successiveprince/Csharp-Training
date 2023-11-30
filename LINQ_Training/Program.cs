using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Training
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //BasicQuery.Method();


            MyClass.Method();                                               // Aggregate Functions in LINQ


            //Queries.Method();


            //MyQueryClass.Method();


            Console.ReadKey();
        }
    }
}
