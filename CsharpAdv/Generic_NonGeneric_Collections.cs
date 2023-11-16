using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CsharpAdv_Day2
{
    class Generic_NonGeneric_Collections
    {
        public void OneDimArray()
        {
            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;     
            foreach(var i in arr)
            {
                Console.WriteLine(i);
            }
        }
        public void TwoDimArray()
        {
            //int[,] a = new int[2, 2];
           int[,] arr = { { 1 ,2} , { 3 , 4} };
        }
        public void JaggedArray()
        {
            int[][] jagged = new int[2][];

            jagged[0] = new int[] { 1, 2, 3 };
            jagged[1] = new int[] { 10, 20 };

        }
        public void MyArrayList()
        {
            ArrayList myList = new ArrayList();

            myList.Add(10);
            myList.Add("Prince");
            myList.Add(10.5);
            myList.Add(DateTime.Now);

            Console.WriteLine("\nArrayList:");
            foreach (var i in myList)
            {               
                Console.WriteLine(i);
            }
        }
        public void MyHashTable()
        {
            Hashtable myHash = new Hashtable();

            myHash.Add(1, "Prince");
            myHash.Add(2, "Ajay");
            myHash.Add(3, "Utkarsh");
            myHash.Add(4, "Govind");
            myHash.Add(5, "Akshat");
            myHash.Add(6, "Yash");

            Console.WriteLine("\nHash Table:");
            foreach(DictionaryEntry i in myHash)
            {
                Console.WriteLine("{0} : {1}" , i.Key , i.Value);
            }
        }

        public void MyQueue()
        {
            Queue myQ = new Queue();

            myQ.Enqueue(2);
            myQ.Enqueue("Prince");
            myQ.Enqueue("Successive");
            myQ.Enqueue(10000);

            Console.WriteLine("\nQueue:");
            foreach(var i in myQ)
            {
                Console.WriteLine(i);
            }
            myQ.Dequeue();
            Console.WriteLine("\nQueue after Dequeue:");
            foreach (var i in myQ)
            {
                Console.WriteLine(i);
            }

        }
        public void MyStack()
        {
            Stack myS = new Stack();

            myS.Push(6);
            myS.Push("Maxx");
            myS.Push("Google");
            myS.Push(23232);

            Console.WriteLine("\nStack:");
            foreach (var i in myS)
            {
                Console.WriteLine(i);
            }
            myS.Pop();
            Console.WriteLine("\nStack afte Pop:");
            foreach (var i in myS)
            {
                Console.WriteLine(i);
            }
        }
        public void myList()
        {
            List<int> list = new List<int>();

            list.Add(5);
            list.Add(10);
            list.Add(15);
            list.Add(15);
            list.Add(20);
            list.Add(25);

            Console.WriteLine("\nList<T>:");
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
            list.Remove(15);
            list.Remove(10);
            Console.WriteLine("\nList<T> after Remove:");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
        public void MyDictionary()
        {
            Dictionary<int, string> myD = new Dictionary<int, string>();

            myD.Add(1, "Prince");
            myD.Add(2, "Maxx");
            myD.Add(3, "Ash");

            Console.WriteLine("\nDictionary<TKey , TValue>:");
            foreach (var i in myD)
            {
                Console.WriteLine("{0} : {1}" ,i.Key , i.Value);
            }
            Console.WriteLine("Count : {0} " , myD.Count);
        }
        public void MyQueueGeneric()
        {
            Queue<int> myQ = new Queue<int>();

            myQ.Enqueue(100);
            myQ.Enqueue(200);
            myQ.Enqueue(300);
            myQ.Enqueue(400);
            myQ.Enqueue(500);
            Console.WriteLine("\nQueue<T>:");
            foreach (var i in myQ)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Count : {0} ", myQ.Count);
        }
    }
}
