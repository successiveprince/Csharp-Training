using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Project
{
    class Student
    {
        public string studentId { get; set; }
        public string studentName{ get; set; }
        public int studentCode { get; set; }
        public int studentSubject { get; set; }

        private List<Course> _courses;

        public Student()
        {
            Course c = new Course();
            c.courseId = 1001;
            c.courseName = "Art & Craft";
            c.courseCode = "A001";
            c.courseSubject = "Painting";
            _courses.Add(c);
        }
        public List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }
        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }
        public void RemoveCourse(Course course)
        {
            _courses.Remove(course);
        }
        public void AddCourse(List<Course> courseList)
        {
            _courses.AddRange(courseList);
        }

        public static void StudentData()
        {
            Student s = new Student();
            Console.WriteLine("Enter Student Id:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student's Name:");
            var name = Console.ReadLine();

            Console.WriteLine("Enter Student's Code:");
            var code = Console.ReadLine();

            Console.WriteLine("Enter Student's Subject:");
            var subject = Console.ReadLine();
        }
    }
}
