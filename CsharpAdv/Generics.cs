using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdv_Day2
{
    public class Generics<T>        //Generic Class
    {
        public T variable;

        public T MyMethod { get; set; }

        public Generics(T value)
        {
            variable = value;
            MyMethod = value;
        }

        public T TestFunction(T para)
        {
            Console.WriteLine("Parameter type: {0} , value: {1}", typeof(T).ToString(), para);
            Console.WriteLine("Return type: {0} , value: {1}", typeof(T).ToString(), variable);

            return variable;
        }      
    }
    public class MyGenericClass
    {
        public void GenericMethod<T1, T2>(T1 Param1, T2 Param2)         //Generics Methods
        {
            Console.WriteLine($"Parameter T1 type: {typeof(T1)}: Parameter T2 type: {typeof(T2)}");
            Console.WriteLine($"Parameter 1: {Param1} : Parameter 2: {Param2}");
        }
    }

}
