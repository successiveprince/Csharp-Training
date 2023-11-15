using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Project
{
    class Student
    {
        public int studentId { get; set; }
        public string studentName{ get; set; }
        public string studentCode { get; set; }
        public string studentCourse { get; set; }

        private static List<Course> _courses = new List<Course>();

        public Student()
        {
            Course c = new Course();
            c.courseId = 1001;
            c.courseName = "Art & Craft";
            c.courseCode = "A001";
            c.courseSubject = "Painting";
            _courses.Add(c);
        }
        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }
        public void AddCourse(Course course)
        {
            string c_id = "";
            int course_id = 0;
            Console.WriteLine("Enter the Course id");
            c_id = Console.ReadLine();
            while (c_id.Length == 0)
            {
                Console.WriteLine("Invalid input,Please enter again");
                c_id = Console.ReadLine();
            }
            while (!int.TryParse(c_id, out course_id))
            {
                Console.WriteLine("Invalid input,Please enter again");
                c_id = Console.ReadLine();
            }
            course.courseId = course_id;

            string c_name = "";
            Console.WriteLine("Enter Course Name");
            c_name = Console.ReadLine();
            while (c_name.Length == 0)
            {
                Console.WriteLine("Invalid input,Please enter again");
                c_name = Console.ReadLine();
            }
            course.courseName = c_name;

            string c_code = "";
            Console.WriteLine("Enter Course Code");
            c_code = Console.ReadLine();
            while (c_code.Length == 0)
            {
                Console.WriteLine("Invalid input,Please enter again");
                c_code = Console.ReadLine();
            }
            course.courseCode = c_code;



            string c_subject = "";
            Console.WriteLine("Enter Course Subject Name");
            c_subject = Console.ReadLine();
            while (c_subject.Length == 0)
            {
                Console.WriteLine("Invalid input,Please enter again");
                c_subject = Console.ReadLine();
            }
            course.courseSubject = c_subject;


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
            Console.WriteLine("Enter Student's Id : ");
            s.studentId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student's name : ");
            s.studentName = Console.ReadLine();

            Console.WriteLine("Enter Student's course: ");
            s.studentCourse = Console.ReadLine();

            Console.WriteLine("Enter Student's code: ");
            s.studentCode = Console.ReadLine();

        }
    }
}
