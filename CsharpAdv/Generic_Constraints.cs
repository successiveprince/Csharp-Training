using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdv_Day2
{
    class Generic_Constraints
    {
        public string name { get; set; }
        public string location { get; set; }
    }
    public class GenericClass<T> where T : class        //For class
    {
        public void MyMethod(T input)
        {
            Console.WriteLine($"Hello {input}");
        }
    }
    public class GenericStruct<T> where T : struct      //For structure
    {
        public T age;
        public void MyMethod()
        {
            Console.WriteLine($"My age is {age}");
        }
    }
    public class GenericNew<T> where T : new()          //For new()
    {
        public T message;
        public void MyNewMethod(T para1 , T para2)
        {
            Console.WriteLine($"Message : {message}");
            Console.WriteLine($"Position : {para1}");
            Console.WriteLine($"Company : {para2}");
        }
    }
    public class NewClass
    {
        public string position { get; set; }
        public string company { get; set; }
    }
    public class GenericBaseClass<T> where T : BaseClass            //For Base Class
    {
        public void MyBaseMethod(T para)
        {
            Console.WriteLine($"Info : {para}");
        }
    }
    public class BaseClass
    {
        public void CallBaseClass()
        {
            Console.WriteLine("Base Class is Called!!!");
        }
    }
    public class DerivedClass : BaseClass
    {
        public string info { get; set; }
    }
    public class GenericInterface<T> where T : MyInterface          //For Interface
    {
        public void InterfaceMethod(T para)
        {
            Console.WriteLine($"Parameter : {para}");
        }
    }
    public interface MyInterface
    {
        void InterfaceMethod();
    }
    public class MyInterfaceClass : MyInterface
    {
        public string name { get; set; }
        public void InterfaceMethod()
        {
            Console.WriteLine("Interface Called!!!");
        }
    }
}
