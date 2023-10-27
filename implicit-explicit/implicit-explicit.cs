using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace implicit_explicit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion

            int a = 10;
            float b = a;
            double c = b;
            decimal d = (decimal) b;

            //Explicit Conversion

            //--double to int
            double age = 22.2;
            int correctAge = Convert.ToInt32(age);
            Console.WriteLine(correctAge);

            //--float to int
            float salary = 1232.32f;
            int correctSalary = Convert.ToInt32(salary);

            //--string to int
            string weight = "23";
            int correctWeight;
            if (int.TryParse(weight, out correctWeight))
            {
                correctWeight = Convert.ToInt32(weight);
                Console.WriteLine(correctWeight);
            }

            //--int to string
            int height = 76;
            string correctHeight = height.ToString();
            Console.WriteLine(correctHeight);


            Console.ReadKey();
        }
    }
}
