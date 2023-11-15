using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Project
{
    class Course : CourseSubject
    {
        public int courseId { get; set; }
        public string courseName { get; set; }
        public string courseCode { get; set; }
        public string courseSubject { get; set; }

        private static List<CourseSubject> _subjects = new List<CourseSubject>();
        public Course()
        {
            CourseSubject cs = new CourseSubject();
            cs.subjectId = 01;
            cs.subjectName = "English";
            cs.subjectCode = "E01";
            _subjects.Add(cs);
        }
        public static List<CourseSubject> Subjects
        {
            get
            {
                return _subjects;
            }
        }
        public void AddSubject(CourseSubject subject)
        {
            string s_id = "";
            int cs_id = 0;
            Console.WriteLine("Enter Subject id");
            s_id = Console.ReadLine();
            while (s_id.Length == 0)
            {
                Console.WriteLine("Invalid input,Please enter again");
                s_id = Console.ReadLine();
            }
            while (!int.TryParse(s_id, out cs_id))
            {
                Console.WriteLine("Invalid input,Please enter again");
                s_id = Console.ReadLine();
            }
            subject.subjectId = cs_id;

            string s_code = "";
            Console.WriteLine("Enter Subject Code");
            s_code = Console.ReadLine();
            while (s_code.Length == 0)
            {
                Console.WriteLine("Invalid input,Please enter again");
                s_code = Console.ReadLine();
            }
            subject.subjectCode = s_code;

            string s_name = "";
            Console.WriteLine("Enter Subject Name");
            s_name = Console.ReadLine();
            while (s_name.Length == 0)
            {
                Console.WriteLine("Invalid input,Please enter again");
                s_name = Console.ReadLine();
            }
            subject.subjectName = s_name;

            _subjects.Add(subject);
        }
        public void RemoveSubject(CourseSubject subject)
        {
            _subjects.Remove(subject);
        }
        public void AddSubject(List<CourseSubject> subjectList)
        {
            _subjects.AddRange(subjectList);
        }
    }
}
