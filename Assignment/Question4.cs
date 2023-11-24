//Question 4 -> Try to use Func, Action and Predicate any program.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class GenericDelegate
    {
        public static float MyAverage(float x, float y, float z)
        {
            return (x + y + z) / 3;
        }
        public static void MyPercentage(float marks, int totalMarks)
        {
            Console.WriteLine("Percentage is " + (marks / totalMarks) * 100);
        }
        public static bool CheckLengthOfString(string input)
        {
            return input.Length > 10;
        }

        public static void Method()
        {
            Func<float, float, float, float> myDele1 = new Func<float, float, float, float>(MyAverage);             // Func
            float ans = myDele1(120f, 85.4f, 100f);
            Console.WriteLine("Average is " + ans);

            Action<float, int> myDele2 = new Action<float, int>(MyPercentage);                                     // Action
            myDele2(68.5f, 100);

            Predicate<string> myDele3 = new Predicate<string>(CheckLengthOfString);                                 // Predicate
            Console.WriteLine("Size of \'Prince Kumar\' is greater than 10? " + myDele3("Prince Kumar"));
        }
    }
}
