using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Training
{
    class MyQueryClass
    {
        public static void Method()
        {
            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Sam",  Age = 16 } ,
                new Student() { StudentID = 5, StudentName = "Mike",  Age = 25 } ,
                new Student() { StudentID = 6, StudentName = "Ash",  Age = 17 } ,
                new Student() { StudentID = 7, StudentName = "Ron" , Age = 19 }
            };

            Console.WriteLine("\n--------- Deferred Execution -----------\n");

            Console.WriteLine("Age below 18 :");
            var teenAger = studentList.Where(s => s.Age < 18).Select(s => new { Age = s.Age, Name = s.StudentName });

            foreach (var i in teenAger)
            {
                Console.WriteLine("{0} : {1}", i.Name, i.Age);
            }

            Console.WriteLine("\nAfter adding one more element : ");
            studentList.Add(new Student() { StudentID = 7, StudentName = "Jiren", Age = 14 });

            Console.WriteLine("Age below 18 :");
            foreach (var i in teenAger)
            {
                Console.WriteLine("{0} : {1}", i.Name, i.Age);
            }

            Console.WriteLine("\n--------- Immediate Execution -----------\n");
            var greaterAge = studentList.Where(s => s.Age > 18).Select(s => new { Age = s.Age, Name = s.StudentName }).ToList();

            Console.WriteLine("Age above 18 :");
            foreach (var i in greaterAge)
            {
                Console.WriteLine("{0} : {1}", i.Name, i.Age);
            }

            Console.WriteLine("\nAfter adding one more element : ");
            studentList.Add(new Student() { StudentID = 8, StudentName = "Goku", Age = 24 });

            Console.WriteLine("Age above 18 :");
            foreach (var i in greaterAge)
            {
                Console.WriteLine("{0} : {1}", i.Name, i.Age);
            }


            Console.WriteLine("\n--------- GroupBy -----------\n");
            var groupedAge = studentList.GroupBy(s => s.Age);

            foreach (var ageGroup in groupedAge)
            {
                Console.WriteLine("Age Group : {0}", ageGroup.Key);
                foreach (var student in ageGroup)
                {
                    Console.WriteLine("Student Name : {0}", student.StudentName);
                }
            }


            Console.WriteLine("\n--------- ToLookUp -----------\n");
            var lookupAge = studentList.ToLookup(s => s.Age);

            foreach (var ageLookup in lookupAge)
            {
                Console.WriteLine("Age Group : {0}", ageLookup.Key);
                foreach (var student in ageLookup)
                {
                    Console.WriteLine("Student Name : {0}", student.StudentName);
                }
            }

        }
    }
}
