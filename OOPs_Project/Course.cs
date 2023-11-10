using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Project
{
    class Course
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
        public string courseCode { get; set; }
        public string courseSubject { get; set; }

        private List<CourseSubject> _students = new List<CourseSubject>();
        public Course()
        {
            CourseSubject cs = new CourseSubject();
            cs.subjectId = 01;
            cs.subjectName = "English";
            cs.subjectCode = "E01";
            _students.Add(cs);
        }
        public List<CourseSubject> Students
        {
            get
            {
                return _students;
            }
        }
        public void AddSubject(CourseSubject subject)
        {
            _students.Add(subject);
        }
        public void RemoveSubject(CourseSubject subject)
        {
            _students.Remove(subject);
        }
        public void AddSubject(List<CourseSubject> subjectList)
        {
            _students.AddRange(subjectList);
        }

        public static void CourseData()
        {
            Student s = new Student();
            Console.WriteLine("Enter Course Id:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Course's Name:");
            var name = Console.ReadLine();

            Console.WriteLine("Enter Course's Code:");
            var code = Console.ReadLine();

            Console.WriteLine("Enter Course's Subject:");
            var subject = Console.ReadLine();
        }
    }
}
