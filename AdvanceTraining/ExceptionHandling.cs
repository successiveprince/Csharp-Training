using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceTraining
{
    public class MarksIsNegativeException : Exception
    {
        public MarksIsNegativeException(string message) : base(message)
        {
            Console.WriteLine("Exception ocuurs");
        }
    }
    class ExceptionHandling
    {
        public void CheckMarks()
        {
            int count = 5;
            try
            {
               
                while (count > 0)
                {
                    Console.WriteLine("Enter your marks : ");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 0)
                    {
                        throw (new MarksIsNegativeException("Marks can't be zero!!!"));
                    }

                    Console.WriteLine("Your Percentage is {0}%" , (input));
                    count--;
                }
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        public void MyDivByZeroException()          //System.DivideByZeroException
        {
            int input;
            Console.WriteLine("Enter your number");
            input = Convert.ToInt32(Console.ReadLine());

            try
            {
                for (int div = 0; div < 5; div++)
                {
                    Console.WriteLine(input / div);
                }
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int div = 1; div < 5; div++)
                {
                    Console.WriteLine("{0} divided by {1} :{2} " ,input , div , input / div);
                }
            }
        }
        public void MyNullReferenceException()          //System.NullReferenceException
        {
            string str = null;

            try
            {
                int length = str.Length;
                Console.WriteLine("Length : " + length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException caught: " + ex.Message);
            }
        }
        public void MyIndexOutOfRangeException()        //System.IndexOutOfRangeException
        {
            int[] numbers = { 1, 2, 3 };
            try
            {
                int value = numbers[3]; 
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException caught: " + ex.Message);
            }

        }
        public void MyFormatException()         //System.FormatException
        {
            string input = "abc";
            try
            {
                int number = int.Parse(input); 
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException caught: " + ex.Message);
            }

        }
        
    }
}
