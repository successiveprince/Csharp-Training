using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    //-------    Q1     --------
    //Find Perfect Number - Sum of all factors(except that number) is equal to that number

    //public class Q1_PerfectNumber
    //{
    //   public static bool Find(int x)
    //    {
    //        if (x <= 0)
    //        {
    //            return false;
    //        }

    //        int sum = 0;
    //        for (int i = 1; i <= x / 2; i++)
    //        {
    //            if (x % i == 0)
    //            {
    //                sum += i;
    //            }
    //        }
    //        if (sum == x)
    //            return true;
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //    public static void IsPerfect()
    //    {
    //        int input;
    //        Console.Write("Enter a Number : ");
    //        input = int.Parse(Console.ReadLine());

    //        if (Find(input))
    //        {
    //            Console.WriteLine(String.Format("{0} is a Perfect Number", input));
    //        }
    //        else
    //        {
    //            Console.WriteLine(String.Format("{0} is not a Perfect Number", input));
    //        }
    //    }
    //    public static void Main(string[] args)
    //    {
    //        Q1_PerfectNumber.IsPerfect();

    //        Console.ReadKey();
    //    }
    //}


    //--------   Q2    -----
    //Find the minimum gap to make the given number a perfect square.

    //class Q2_MinimumGap
    //{
    //    private static int Find(int input)
    //    {
    //        int GreaterSquareRoot = (int)Math.Ceiling(Math.Sqrt(input));
    //        int LowerSquareRoot = (int)Math.Floor(Math.Sqrt(input));

    //        int GreaterPerfectSquare = GreaterSquareRoot * GreaterSquareRoot;
    //        int LowerPerfectSquare = LowerSquareRoot * LowerSquareRoot;

    //        int minimumGap = Math.Min(GreaterPerfectSquare - input, input - LowerPerfectSquare);

    //        return minimumGap;
    //    }
    //    public static void FindMinimumGap()
    //    {
    //        int input;
    //        Console.Write("Enter a Number : ");
    //        input = Convert.ToInt32(Console.ReadLine());

    //        int result = Find(input);

    //        Console.WriteLine("The minimum gap to make {0} a perfect square is {1}", input, result);
    //    }
    //    public static void Main(string[] args)
    //    {
    //        Q2_MinimumGap.FindMinimumGap();

    //        Console.ReadKey();
    //    }
    //}


    //--------   Q3    ---------
    //Find out the pairs in an array where the sum of the value at index of the pair is less than a given number.

    //class Q3_FindPairs
    //{
    //    public static void ShowPairs(int[] array, int size, int targetSum)
    //    {
    //        Console.WriteLine("Pairs with sum less than " + targetSum + ":");

    //        for (int i = 0; i < size - 1; i++)
    //        {
    //            for (int j = i + 1; j < size; j++)
    //            {
    //                if (array[i] + array[j] < targetSum)
    //                {
    //                    Console.WriteLine("[{0},{1}] with indices ({2},{3})", array[i], array[j], i, j);
    //                }
    //            }
    //        }
    //    }

    //    public static void FindPairs()
    //    {
    //        int size;
    //        Console.Write("Enter the size of array : ");
    //        size = Convert.ToInt32(Console.ReadLine());

    //        int[] array = new int[size];
    //        for (int i = 0; i < size; i++)
    //        {
    //            Console.Write(String.Format("Enter element at index {0} : ", i));
    //            array[i] = Convert.ToInt32(Console.ReadLine());
    //        }

    //        Console.WriteLine("\nArray is : ");
    //        for (int i = 0; i < size; i++)
    //        {
    //            Console.Write("{0} ", array[i]);
    //        }

    //        int target;
    //        Console.Write("\n\nEnter your target value : ");
    //        target = Convert.ToInt32(Console.ReadLine());

    //        ShowPairs(array, size, target);
    //    }
    //    public static void Main(string[] args)
    //    {
    //        Q3_FindPairs.FindPairs();

    //        Console.ReadKey();
    //    }

    //}


    //------   Q4    -------
    //Find if the string number is magical or not.
    //-> Magical number : Sum of all digits till single digit == 1 , magical number else not magical

    //class Q4_MagicalNumber
    //{
    //    public static void FindMagicalNumber(int num)
    //    {
    //        int result = num;
    //        int sum = 0;
    //        while (num > 0)
    //        {
    //            int x = num % 10;
    //            sum += x;
    //            num = num / 10;
    //            if (num == 0 && sum > 9)
    //            {
    //                num = sum;
    //                sum = 0;
    //            }
    //        }
    //        if (sum == 1)
    //        {
    //            Console.WriteLine("{0} is a magical number.", result);
    //        }
    //        else
    //        {
    //            Console.WriteLine("{0} is not a magical number.", result);
    //        }
    //    }
    //    public static void CheckMagicalNumber()
    //    {
    //        string input;
    //        Console.WriteLine("Enter Your Number: ");
    //        input = Console.ReadLine();
    //        int num;
    //        if (int.TryParse(input, out num))
    //        {
    //            FindMagicalNumber(num);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Wrong Input!!!");
    //        }
    //    }
    //    public static void Main(string[] args)
    //    {
    //        Q4_MagicalNumber.CheckMagicalNumber();
    //        Console.ReadKey();
    //    }
    //}


    //------    Q5    -------
    //Program to remove multiple spaces from the given string and make sure there is single space between all words.

    //class Q5_RemoveSpaces
    //{
    //    public static void RemoveSpacesFromString(string input)
    //    {
    //        StringBuilder sb = new StringBuilder();

    //        bool isSpace = false;

    //        for (int i = 0; i < input.Length; i++)
    //        {
    //            if (input[i] == ' ')
    //            {
    //                if (!isSpace)
    //                {
    //                    sb.Append(' ');
    //                    isSpace = true;
    //                }
    //            }
    //            else
    //            {
    //                sb.Append(input[i]);
    //                isSpace = false;
    //            }
    //        }
    //        Console.WriteLine("Resultant String: {0}" ,sb.ToString().Trim());
    //    }
    //    public static void RemoveSpaces()
    //    {
    //        Console.WriteLine("Enter your string: ");
    //        string input = Console.ReadLine();
    //        RemoveSpacesFromString(input);
    //    }

    //    public static void Main(string[] args)
    //    {
    //        Q5_RemoveSpaces.RemoveSpaces();
    //        Console.ReadKey();
    //    }
    //}



    //------    Q6    ------
    //Find out 3rd largest value in an integer array.

    //class Q6_ThirdLargest
    //{
    //    public static void FindThirdLargestValue(int[] array)
    //    {
    //        int n = array.Length;

    //        int firstLargest = int.MinValue;
    //        int secondLargest = int.MinValue;
    //        int thirdLargest = int.MinValue;
    //        for(int i = 0; i < n; i++)
    //        {
    //            if(array[i] > firstLargest)
    //            {
    //                thirdLargest = secondLargest;
    //                secondLargest = firstLargest;
    //                firstLargest = array[i];                  
    //            }
    //            else if(array[i] > secondLargest && array[i] < firstLargest)
    //            {
    //                thirdLargest = secondLargest;
    //                secondLargest = array[i];
    //            }
    //            else if(array[i] > thirdLargest && array[i] < secondLargest)
    //            {
    //                thirdLargest = array[i];
    //            }
    //        }
    //        Console.WriteLine();
    //        Console.WriteLine("Third largest value is {0}", thirdLargest);
    //    }

    //    public static void ThirdLargestValue()
    //    {
    //        int size;
    //        Console.Write("Enter the size of array : ");
    //        size = Convert.ToInt32(Console.ReadLine());
    //        if (size <= 2)
    //        {
    //            Console.WriteLine("Invalid Input!!!");
    //            return;
    //        }

    //        int[] array = new int[size];
    //        for (int i = 0; i < size; i++)
    //        {
    //            Console.Write(String.Format("Enter element at index {0} : ", i));
    //            array[i] = Convert.ToInt32(Console.ReadLine());
    //        }

    //        Console.WriteLine("\nArray is : ");
    //        for (int i = 0; i < size; i++)
    //        {
    //            Console.Write("{0} ", array[i]);
    //        }

    //        FindThirdLargestValue(array);
    //    }
    //    public static void Main(string[] args)
    //    {
    //        Q6_ThirdLargest.ThirdLargestValue();
    //        Console.ReadKey();
    //    }
    //}


    //------    Q7     ------
    //Product of array element except that particular element.

    class Q7_ProductArray
    {

        public static void FindProductArray(int[] array)
        {
            int n = array.Length;
            int[] result = new int[n];
            for(int i = 0; i < n; i++)
            {
                int product = 1;
                for (int j = 0; j < n; j++)
                {
                    if(i != j)
                    {
                        product = product * array[j];
                    }
                    
                }
                result[i] = product;
            }
            Console.WriteLine("\nArray after product is : ");
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("{0} ", result[i]);
            }
        }
        public static void ProductArray()
        {
            int size;
            Console.Write("Enter the size of array : ");
            size = Convert.ToInt32(Console.ReadLine());
            if (size <= 2)
            {
                Console.WriteLine("Invalid Input!!!");
                return;
            }

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write(String.Format("Enter element at index {0} : ", i));
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nArray is : ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            FindProductArray(array);
        }
        public static void Main(string[]  args)
        {
            Q7_ProductArray.ProductArray();
            Console.ReadKey();
        }

    }
}
