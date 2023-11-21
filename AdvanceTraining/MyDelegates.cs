using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining
{
	public delegate void AddDelegate(int x, int y);
	public delegate string GreetDelegate(string str);
	public delegate void CourseDelegate(string course);
	class MyDelegates
    {
		public void AddNums(int a, int b)
		{
			Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
		}
		public static string Greet(string name)
		{
			return "Hello " + name;
		}
		public void Course(string course)
        {
			Console.WriteLine("Your Course is " + course);
        }

		public static void Method()
		{
			MyDelegates obj = new MyDelegates();

			//obj.AddNums(100, 40);

			//calling a function using a delegate
			AddDelegate ad = new AddDelegate(obj.AddNums);
			ad(100, 40);

			// call a delegate as method
			ad.Invoke(34, 76);

			//string str = MyDelegates.Greet("Akshat");
			//Console.WriteLine(str);

            GreetDelegate gd = new GreetDelegate(MyDelegates.Greet);
			string str = gd("He Who Remains");
			Console.WriteLine(str);


			CourseDelegate c = new CourseDelegate(obj.Course);
			c("MCA");

			Console.ReadKey();
		}
	}
}

