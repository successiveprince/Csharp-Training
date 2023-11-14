using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvanceDay1
{
    public class A
    {
        public readonly string name = "Prince";
        public readonly string department;

        public static string size = "Large";
        public readonly static string position = "Manager"; 

        public A()
        {
            name = "Maxx";
            size = "Small";
            //position = "Trainee";
        }
        //public void Change()
        //{
        //    name = "Ajay";
        //}
        static A()
        {
            position = "Trainee";
        }

    }
    public struct Books
    {
        //public B()
        //{
        //    A.size = "Medium";
        //    //A.position = "IT";

        //}
        private string _title;
        private string _author;
        private string _subject;
        private int _id;

        public Books(string title , string author , string subject , int id)
        {
            _title = title;
            _author = author;
            _subject = subject;
            _id = id;
        }
        //public Books()
        //{
        //    _author = "Prince";
        //    _subject = "Maths";
        //    _id = 10;
        //    _title = "My Title";
        //}
        public void PrintBook()
        {
            Console.WriteLine("Book id : {0}\nTitle : {1}\nAuthor : {2}\nSubject:{3}" , _id , _title , _author , _subject);
        }
    }

    public class Logging
    {
        public enum LogType
        {
            Error =500,
            Warning = 800,
            Fatal = 900,
            Information = 1000
        }
        public void WriteLog(string logMsg , LogType logType)
        {
            switch (logType)
            {
                case LogType.Error:
                    Console.WriteLine("Error!!!");
                    break;
                case LogType.Warning:
                    Console.WriteLine("Warning!!!");
                    break;
                case LogType.Fatal:
                    Console.WriteLine("Fatal!!!");
                    break;
                case LogType.Information:
                    Console.WriteLine("Information!!!");
                    break;
            }
        }

    }
    class Program
    {
        //public Program()
        //{
        //   Program.name;
        //}
        static void Main(string[] args)
        {
            const int age = 21;


            //age = 22;

            //public const string name = "Prince";

            //public const string size;


            A obj = new A();
            Console.WriteLine(obj.name);

            Logging logging = new Logging();

            int value1 = (int)Logging.LogType.Error;
            Console.WriteLine(value1);
            int value2 = (int)Logging.LogType.Warning;
            Console.WriteLine(value2);
            int value3 = (int)Logging.LogType.Fatal;
            Console.WriteLine(value3);
            int value4 = (int)Logging.LogType.Information;
            Console.WriteLine(value4);

            logging.WriteLog("Message" ,Logging.LogType.Warning);


            Books newBook = new Books("My title" , "Prince" , "Math" , 10);
            newBook.PrintBook();

            Console.ReadKey();

        }
        
    }

}
