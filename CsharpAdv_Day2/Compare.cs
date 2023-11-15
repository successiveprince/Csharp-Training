using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdv_Day2
{
    class Compare
    {
        public bool IsEqual<T>(T a , T b)   //Generic Method
        {
            return a.Equals(b);
        }
        //public bool IsEqual(string a, string b)
        //{
        //    return a.Equals(b);
        //}
    }
}
