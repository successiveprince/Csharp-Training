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
    public class MyClass
    {
        public static void Method()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student() {StudentID = 1 , StudentName = "Prince" , Age = 22},
                new Student() {StudentID = 2 , StudentName = "Akshat" , Age = 20},
                new Student() {StudentID = 3 , StudentName = "Ajay" , Age = 23},
                new Student() {StudentID = 4 , StudentName = "Utkarsh" , Age = 21},
                new Student() {StudentID = 5 , StudentName = "Yash" , Age = 25},
                new Student() {StudentID = 6 , StudentName = "Govind" , Age = 19},
                new Student() {StudentID = 7 , StudentName = "Prince" , Age = 18}
            };

            var oldest = studentList.Max(s => s.Age);                               // MAX
            Console.WriteLine("\nMax age : " + oldest);

            var youngest = studentList.Min(s => s.Age);                             // MIN
            Console.WriteLine("\nMin age : " + youngest);

            var totalStudent = studentList.Count(s => s.Age >=20);                  // COUNT
            Console.WriteLine("\nTotal age >= 20 : " + totalStudent);

            var sum = studentList.Sum(s => s.Age);                                  // SUM
            Console.WriteLine("\nSum of age : " + sum);

            var avg = studentList.Average(s => s.Age);                              // Average
            Console.WriteLine("\nAverage of age : " + avg);

            Console.WriteLine("\n------------ OrderBy & OrderByDescending ---------------");
            var sortAsc = studentList.OrderBy(s => s.StudentName);                  // OrderBy
            var sortDesc = studentList.OrderByDescending(s => s.StudentName);       // OrderByDescending

            Console.WriteLine("\nName in Ascending order : ");
            foreach(var a in sortAsc)
            {
                Console.WriteLine(a.StudentName);
            }
            Console.WriteLine("\nName in Descending order : ");
            foreach (var d in sortDesc)
            {
                Console.WriteLine(d.StudentName);
            }

            Console.WriteLine("\n------------ ThenBy & ThenByDescending ---------------");
            var secondLevelSortAsc = studentList.OrderBy(s => s.StudentName).ThenBy(s => s.Age);                       // ThenBy
            var secondLevelSortDesc = studentList.OrderByDescending(s => s.StudentName).ThenByDescending(s => s.Age);  // ThenByDescending

            Console.WriteLine("\nSecond Level of Sorting using ThenBy in Age : ");
            foreach (var a in secondLevelSortAsc)
            {
                Console.WriteLine("{0} : {1} " , a.StudentName , a.Age);
            }
            Console.WriteLine("\nSecond Level of Sorting using ThenByDescending in Age : ");
            foreach (var d in secondLevelSortDesc)
            {
                Console.WriteLine("{0} : {1} ", d.StudentName, d.Age);
            }

            Console.WriteLine("\n------------ Skip Take SkipWhile & TakeWhile ---------------");
            var skip = studentList.Skip(2);                                             // Skip
            var take = studentList.Take(3);                                             // Take
            var skipWhile = studentList.SkipWhile(s => s.Age >= 20);                    // SkipWhile
            var takeWhile = studentList.TakeWhile(s => s.Age >= 20);                    // TakeWhile

            Console.WriteLine("\nSkip 2 elements : ");
            foreach (var i in skip)
            {
                Console.WriteLine(i.StudentName);
            }
            Console.WriteLine("\nTake 3 elements : ");
            foreach (var i in take)
            {
                Console.WriteLine(i.StudentName);
            }
            Console.WriteLine("\nSkipWhile Age >= 20 : ");
            foreach (var i in skipWhile)
            {
                Console.WriteLine(i.StudentName);
            }
            Console.WriteLine("\nTakeWhile Age >= 20 ");
            foreach (var i in takeWhile)
            {
                Console.WriteLine(i.StudentName);
            }


            List<int> marks = new List<int>() { 7 , 10 , 23 , 21 , 32 , 34};
            List<string> number = new List<string>() { null, "Two", "Three", "Four", "Five" , null };
            List<string> emptyList = new List<string>();
            List<int> age = new List<int>() { 22 };

            Console.WriteLine("\n------------ First & FirstOrDefault ---------------");
            Console.WriteLine("\n1st Even Element in marks : {0}", marks.First(s=> s % 2 == 0));                    // First & FirstOrDefault
            Console.WriteLine("\n1st Element in marks : {0}", marks.First());
            Console.WriteLine("\n1st Element of string list (that is null) using First() : " + number.First());
            Console.WriteLine("\nFirstOrDefault : {0}", marks.FirstOrDefault(s => s == 100));

            Console.WriteLine("\n------------ Last & LastOrDefault ---------------");
            Console.WriteLine("\nLast Element in marks : " + marks.Last());                                         // Last & LastOrDefault
            Console.WriteLine("\nLastOrDefault : " + marks.LastOrDefault(s => s == 32));
            Console.WriteLine("\nLast Element in number : " + number.Last());

            Console.WriteLine("\n------------ Single & SingleOrDefault ---------------");                           // Single & SingleOrDefault
            Console.WriteLine("\nAge using Single() : {0}", age.Single());
            Console.WriteLine("\nSingleOrDefault : " + emptyList.SingleOrDefault());

        }
    }
}
