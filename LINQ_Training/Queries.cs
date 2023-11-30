using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Training
{
    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals(Student s1, Student s2)
        {
            return s1.StudentID == s2.StudentID && s1.StudentName.ToLower() == s2.StudentName.ToLower();
        }
        public int GetHashCode(Student obj)
        {
            return obj.StudentID.GetHashCode();
        }
    }

    class Queries
    {
        public static void Method()
        {
            List<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ash",  Age = 26 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };
            List<Student> studentList2 = new List<Student>() {
                new Student() { StudentID = 4, StudentName = "Ash",  Age = 25 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };


            Console.WriteLine("\n------------- Distinct -------------");
            var distinctStudnets = studentList.Distinct(new StudentComparer());
            foreach (var item in distinctStudnets)
            {
                Console.WriteLine("StudentID : {0}, StudentName : {1}, Age : {2}", item.StudentID, item.StudentName, item.Age);
            }


            Console.WriteLine("\n------------- Except -------------");
            var exceptStudnets = studentList.Except(studentList2, new StudentComparer());
            foreach (var item in exceptStudnets)
            {
                Console.WriteLine("StudentID : {0}, StudentName : {1}, Age : {2}", item.StudentID, item.StudentName, item.Age);
            }


            Console.WriteLine("\n------------- Intersect -------------");
            var intersectStudnets = studentList.Intersect(studentList2, new StudentComparer());
            foreach (var item in intersectStudnets)
            {
                Console.WriteLine("StudentID : {0}, StudentName : {1}, Age : {2}", item.StudentID, item.StudentName, item.Age);
            }


            Console.WriteLine("\n------------- Union -------------");
            var unionStudnets = studentList.Union(studentList2, new StudentComparer());
            foreach (var item in unionStudnets)
            {
                Console.WriteLine("StudentID : {0}, StudentName : {1}, Age : {2}", item.StudentID, item.StudentName, item.Age);
            }


            Console.WriteLine("\n------------- Select -------------");
            var selectStudnets = studentList.Select(s => new {Id = s.StudentID , Name = s.StudentName , Age = s.Age });
            foreach (var item in selectStudnets)
            {
                Console.WriteLine("StudentID : {0}, StudentName : {1}, Age : {2}", item.Id , item.Name, item.Age);
            }

        }
    }
}
