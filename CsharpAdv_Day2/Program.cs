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
            Compare compare = new Compare();

            var result = compare.IsEqual(5, 6);
            Console.WriteLine(result);
            var output = compare.IsEqual<int>(5, 5);
            Console.WriteLine(output);
            var ans = compare.IsEqual<string>("ads", "aa");
            Console.WriteLine(ans);

            //Generics<int> G = new Generics<int>(50);
            //G.TestFunction(100);

            //Generics<string> G1 = new Generics<string>("Hello");
            //G1.TestFunction("World");
            var GG = new Generics<CreateInstance>();
            GG.CreateInstance();


            Console.ReadKey();
        }
    }
}
