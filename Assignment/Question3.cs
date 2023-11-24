//Question 3 -> How to define a delegate and call any method or event using it? 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Delegates
    {
        public delegate void MyPercentage(float marks, int totalMarks);         // Defining Delegate

        public void FindPercentage(float marks , int totalMarks)
        {
            Console.WriteLine("Percentage : " + (marks / totalMarks) * 100);
        }

        public static void MyMethod()
        {
            Delegates obj = new Delegates();
            MyPercentage delePercentage = new MyPercentage(obj.FindPercentage);

            delePercentage(50, 100);                                            // calling method using Delegate
        }
    }
}
