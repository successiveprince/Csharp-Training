using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = -1;
            int choice;
            do
            {
                Console.WriteLine("Welcome to the OOPs Universe");
                Console.WriteLine("Choose Your Option:");
                Console.WriteLine("1.Add Subject");
                Console.WriteLine("2.Add Course");
                Console.WriteLine("3.Add Student");
                Console.WriteLine("4.View All Subjects");
                Console.WriteLine("5.View All Courses");
                Console.WriteLine("6.View All Students");
                Console.WriteLine("7.Find Subject by Name/Code");
                Console.WriteLine("8.Find Course by Name/Code");
                Console.WriteLine("9.Find Student by Name/Code");
                Console.WriteLine("10.Exit");

                choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1: Student.StudentData();
                        break;
                    case 2: Course.CourseData();
                        break;
                }

            }
            while(i != -1) ;
        }
    }
}
