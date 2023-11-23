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

	public delegate void RectDelegate(float height, float width);           // Multicasting of Delegates for return type "Void"

	public delegate int IntDelegate();                                      // Multicasting of Delegates for return type "Int"
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
		public void area(float height , float width)
        {
			Console.WriteLine("Area : " + height * width);
        }
		public void perimeter(float height , float width)
        {
			Console.WriteLine("Perimeter : " + 2 * (height + width));
        }
		public int Method1()
        {
			return 1;
        }
		public int Method2()
        {
			return 2;
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
			

			//------ multicasting of delegates----------

			Console.WriteLine("\nMulticasting of Delegates\n");         
			MyDelegates rect = new MyDelegates();                   // multicasting of delegates for return type "Void"
			RectDelegate rectDele = new RectDelegate(rect.area);
			rectDele(10, 20);

			rectDele += rect.perimeter;
			rectDele(5, 10);

			MyDelegates M = new MyDelegates();					// multicasting of delegates for return type "Int"
			IntDelegate value = new IntDelegate(M.Method1);
			value += M.Method2;
			Console.WriteLine("Return type int : " + value());

			Console.ReadKey();
		}
	}
}

