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
            List<Student> studentList = new List<Student>();

            int choice = -1;
            do
            {
                Console.WriteLine("--------Welcome to the OOPs Universe---------");
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
                Console.WriteLine();

                bool check = true;
                while (check)
                {
                    Console.WriteLine("\nEnter your choice ");
                    var x = Console.ReadLine();
                    bool input = int.TryParse(x, out choice);
                    if (!input)
                    {
                        Console.WriteLine("Invalid input!!!");
                    }
                    else
                        check = false;
                }
                switch (choice)
                {
                    case 1:
                        bool checkLoop1 = false;
                        Course course1 = new Course();
                        while(!checkLoop1)
                        {
                            CourseSubject newSubject = new CourseSubject();

                            course1.AddSubject(newSubject);
                            Console.WriteLine("Do you want to add more subject?");
                            Console.WriteLine("Type Y/N");
                            string input = Console.ReadLine();

                            if ((input.Equals("N") || input.Equals("n")))
                            {
                                checkLoop1 = true;
                            }
                        }
                        Console.WriteLine("Subject added Successfully!!!");
                        
                        break;
                    case 2:
                        bool checkLoop2 = false;
                        Student student = new Student();
                        while (!checkLoop2)
                        {
                            Course course2 = new Course();
                            student.AddCourse(course2);
                            Console.WriteLine("Do you want to add more Course?");
                            Console.WriteLine("Type Y/N");
                            string input = Console.ReadLine();
                            if ((input.Equals("N") || input.Equals("n")))
                            {
                                checkLoop2 = true;
                            }
                        }
                        Console.WriteLine("Course added Successfully!!!");
                        break;
                    case 3:
                        Console.WriteLine("Enter Student's Id : ");
                        var s_Id = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter Student's Name : ");
                        var s_Name = Console.ReadLine();

                        Console.WriteLine("Enter Student's code : ");
                        var s_Code = Console.ReadLine();

                        Console.WriteLine("Enter Student's course : ");
                        var s_Course = Console.ReadLine();

                        Student s1 = new Student();
                        s1.studentId = s_Id;
                        s1.studentName = s_Name;
                        s1.studentCode = s_Code;
                        s1.studentCourse = s_Course;

                        studentList.Add(s1);
                        break;
                    case 4:
                        Console.WriteLine("List of all Subjects:\n");
                        Console.WriteLine("SubjectId\tSubjectName\tSubjectCode\n");
                        foreach (var temp in Course.Subjects)
                        {
                            Console.WriteLine("{0}\t\t{1}\t\t{2}", temp.subjectId, temp.subjectName, temp.subjectCode);
                        }

                        break;
                    case 5:
                        Console.WriteLine("List of all Courses:\n");
                        Console.WriteLine("CourseId\tCourseName\tCourseSubject\tCourseCode\n");
                        foreach (var temp in Student.Courses)
                        {
                            Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}", temp.courseId, temp.courseName, temp.courseSubject , temp.courseCode);
                        }

                        break;
                    case 6:
                        Console.WriteLine("List of all Students: ");
                        Console.WriteLine("StudentId\tStudentName\tStudentCode\tStudentCourse\n");
                        foreach (var temp in studentList)
                        {
                            Console.WriteLine("{0}\t{1}\t{2}\t{3}", temp.studentId, temp.studentName, temp.studentCode, temp.studentCourse);

                        }

                        break;
                    case 7:

                        List<CourseSubject> subjects = new List<CourseSubject>();
                        subjects.AddRange(Course.Subjects);

                        Console.WriteLine("Enter Name/Code of the Subject:");
                        string searchItem1 = Console.ReadLine();
                        var foundSubjects = subjects.FindAll(sub =>
                                                 sub.subjectName.IndexOf(searchItem1, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                 sub.subjectCode.IndexOf(searchItem1, StringComparison.OrdinalIgnoreCase) >= 0);

                        if (foundSubjects.Count > 0)
                        {
                            Console.WriteLine("Subjects:");
                            Console.WriteLine("SubjectId\tSubjectName\tSubjectCode\n");
                            foreach (var subject in foundSubjects)
                            {
                                Console.WriteLine("{0}\t\t{1}\t\t{2}", subject.subjectId, subject.subjectName, subject.subjectCode);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No Subject found!!!");
                        }
                        break;
                    case 8:
                        List<Course> course = new List<Course>();
                        course.AddRange(Student.Courses);

                        Console.WriteLine("Enter Name/Code of Course:");
                        string searchItem2 = Console.ReadLine();

                        var foundCourses = course.FindAll(co =>
                                         co.courseName.IndexOf(searchItem2, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                         co.courseCode.IndexOf(searchItem2, StringComparison.OrdinalIgnoreCase) >= 0);

                        if (foundCourses.Count > 0)
                        {
                            Console.WriteLine("Courses:");
                            Console.WriteLine("CourseId\tCourseName\tCourseSubject\tCourseCode\n");
                            foreach (var temp in foundCourses)
                            {
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t{3}", temp.courseId, temp.courseName, temp.courseSubject, temp.courseCode);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No Course Found!!!.");
                        }
                        break;
                    case 9:
                        Console.WriteLine("Enter Name/Code of Student:");
                        string searchItem3 = Console.ReadLine();
                        var foundStudent = studentList.FindAll(st =>
                                            st.studentName.IndexOf(searchItem3, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                            st.studentCode.IndexOf(searchItem3, StringComparison.OrdinalIgnoreCase) >= 0);

                        if (foundStudent.Count > 0)
                        {
                            Console.WriteLine("Students:");
                            Console.WriteLine("StudentId\tStudentName\tStudentCode\tStudentCourse\n");
                            foreach (var temp in foundStudent)
                            {
                                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", temp.studentId, temp.studentName, temp.studentCode, temp.studentCourse);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No Course Found!!!.");
                        }
                        break;
                    case 10:
                        Console.WriteLine("\nEnd of Program\nThank You for visiting");
                        choice = -1;
                        Environment.Exit(1);

                        break;

                    default:
                        Console.WriteLine("Invalid Input!!!\n");
                        break;

                }

            }
            while(choice != -1);

            Console.ReadKey();
        }
    }
}
