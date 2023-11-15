using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdv_Day2
{
    public class Generics<T> where T: new()         //Generics Constraints -> new()
    {
        public T variable;

        public T MyMethod { get; set; }

        //public Generics(T value)
        //{
        //    variable = value;
        //    MyMethod = value;
        //}

        public T TestFunction(T para)
        {
            Console.WriteLine("Parameter type: {0} , value: {1}", typeof(T).ToString(), para);
            Console.WriteLine("Return type: {0} , value: {1}", typeof(T).ToString(), variable);

            return variable;
        }
        //public Generics()
        //{
        //    Console.WriteLine("New Instnace Created!!!");
        //}

        public T CreateInstance()
        {
            
            return new T();
        }
    }

    class CreateInstance
    {
        public CreateInstance()
        {
            Console.WriteLine("New Instance Created!!!");
        }
    }
}
