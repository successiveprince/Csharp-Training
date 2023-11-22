using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CsharpAdv_Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compare compare = new Compare();

            //var result = compare.IsEqual(5, 6);
            //Console.WriteLine(result);
            //var output = compare.IsEqual<int>(5, 5);
            //Console.WriteLine(output);
            //var ans = compare.IsEqual<string>("ads", "aa");
            //Console.WriteLine(ans);



            //---------------Generics---------------------

            //Generics<int> G = new Generics<int>(89);
            //G.TestFunction(100);

            //Generics<string> G1 = new Generics<string>("maxx");
            //G1.TestFunction("World");

            //MyGenericClass MG = new MyGenericClass();
            //MG.GenericMethod<int, string>(10, "Hello");



            //-----------Generic Constraints---------------

            //GenericClass<Generic_Constraints> myClass = new GenericClass<Generic_Constraints>();    // Generic Constraints for class
            //Generic_Constraints G = new Generic_Constraints() { name = "Prince", location = "Noida" };
            //myClass.MyMethod(G);



            //GenericStruct<int> S = new GenericStruct<int>();                                       // Generic Constraints for structure
            //S.age = 22;
            //S.MyMethod();



            //GenericNew<NewClass> newClass = new GenericNew<NewClass>();                           // Generic Constraints for new()
            //NewClass n1 = new NewClass() { position = "Trainee", company = "Successive" };
            //NewClass n2 = new NewClass() { position = "Associate", company = "Successive" };
            //NewClass n3 = new NewClass() { position = "Senior Associate", company = "Successive" };

            //newClass.message = n1;
            //newClass.MyNewMethod(n2 , n3);



            //GenericBaseClass<DerivedClass> GD = new GenericBaseClass<DerivedClass>();               // Generic Constraints for Base Class
            //DerivedClass d = new DerivedClass() { info = "Prince Noida" };

            //GD.MyBaseMethod(d);
            //d.CallBaseClass();



            GenericInterface<MyInterfaceClass> GI = new GenericInterface<MyInterfaceClass>();         // Generic Constraints for Interface
            MyInterfaceClass I1 = new MyInterfaceClass() { name = "Prince" };
            GI.InterfaceMethod(I1);





            //-------Generic and Non-Generic Collections---------

            //Generic_NonGeneric_Collections A = new Generic_NonGeneric_Collections();

            //A.OneDimArray();
            //A.MyArrayList();
            //A.MyHashTable();
            //A.MyQueue();
            //A.MyStack();
            //A.myList();
            //A.MyDictionary();
            //A.MyQueueGeneric();

            Console.ReadKey();
        }
    }
}
