using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Interface
{
    interface Interface1
    {
        void Display();
    }
    interface Interface2
    {
        void Show();
    }
    struct MyStructure : Interface1 , Interface2
    {
        public void Display()
        {
            Console.WriteLine("This is Interface 1");
        }
        void Interface2.Show()
        {
            Console.WriteLine("This is Interface 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyStructure A1 = new MyStructure();
            A1.Display();

            //using dynamic binding(late binding)
            Interface2 A2;
            A2 = new MyStructure();
            A2.Show();

            Console.ReadKey();
        }
    }
}
