using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework03
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task01

            //int i, inputNum;
            //Console.WriteLine("Please enter number larger than 2:");
            //string x = Console.ReadLine();
            //inputNum = Convert.ToInt32(x);

            //Console.Write("Numbers who can be divide with 3 are: ");
            //for (i = 1; i <= inputNum; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    if (inputNum <= 2)
            //    {
            //        Console.WriteLine("Not a option");
            //    }
            //}
            //Console.ReadLine();

            #endregion
            #region task02

            //int i, inputNum;
            //Console.WriteLine("Please enter number larger than 5:");
            //string x = Console.ReadLine();
            //inputNum = Convert.ToInt32(x);

            //Console.Write("Numbers who can be divide 2 and 3: ");
            //for (i = 1; i <= inputNum; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    if (inputNum <= 5)
            //    {
            //        Console.WriteLine("Not a option");
            //    }
            //}
            //Console.ReadLine();

            #endregion
            #region task03

            //int inputNum, sum;
            //Console.WriteLine("Please enter one number:");
            //string x = Console.ReadLine();
            //inputNum = Convert.ToInt32(x);
            //sum = 0;
            //while (inputNum != 0)
            //{
            //    sum += inputNum % 10;
            //    inputNum /= 10;
            //}
            //Console.Write("The product of digits of your number is: " + sum);
            //Console.ReadLine();

            #endregion
            #region task04
            //int i, inputNum, sum;
            //Console.WriteLine("Please enter one number:");
            //string x = Console.ReadLine();
            //inputNum = Convert.ToInt32(x);
            //sum = 0;
            //for (i = 1; i <= inputNum; i++)
            //{
            //    if (i % 2 == 0) { sum = sum + i; }
            //}
            //Console.WriteLine("The sum of all even numbers in this range is " + sum);
            //Console.ReadLine();
            #endregion
            #region task05

            //int i, inputNum, sum;
            //Console.WriteLine("Please enter one number:");
            //string x = Console.ReadLine();
            //inputNum = Convert.ToInt32(x);
            //sum = 0;
            //for (i = 1; i <= inputNum; i++)
            //{
            //    if (i % 2 != 0) { sum = sum + i; }
            //}
            //Console.WriteLine("The sum of all odd numbers in this range is " + sum);
            //Console.ReadLine();
            #endregion
            #region task06
            //int i, sum, inputNum;
            //Console.WriteLine("Please enter one number:");
            //string x = Console.ReadLine();
            //inputNum = Convert.ToInt32(x);
            //sum = 0;
            //for (i = 1; i <= inputNum; i++)
            //{
            //    if (i % 5 == 0) { sum = sum + i; }
            //}
            //Console.WriteLine("Sum of all numbers that divide 5 in this range is " + sum);
            //Console.ReadLine();
            #endregion
            #region task07
            //Console.WriteLine("Array - normal: ");
            //string[] array;
            //array = new string[4];
            //array = new string[4] { "a", "b", "c", "d" };

            //foreach (string value in array)
            //{
            //    Console.WriteLine(value);
            //}
            //Console.WriteLine();
            //Console.WriteLine("Reverse Array: ");
            //Array.Reverse(array);
            //foreach (string value in array)
            //{
            //    Console.WriteLine(value);
            //}
            //Console.WriteLine();


            //Console.ReadLine();
            #endregion
            #region task08
            //string[] niza1 = new string[4] { "pen", "pencil", "marker", "highlighter" };
            //string[] niza2 = new string[4] { "liner", "pen", "tiger", "pencil" };
            //if ((niza1.Length > niza2.Length) || (niza1.Length < niza2.Length))
            //{
            //    Console.WriteLine("presented arrays are not equal!");
            //}
            //else
            //{
            //    for (int i = 0; i < niza1.Length; i++)
            //    {
            //        if (niza1[i] != niza2[i])
            //        {
            //            Console.WriteLine("presented arrays are not equal!");
            //            break;
            //        }
            //    }
            //}
            //Console.ReadLine();
            #endregion
            #region task012
            //int num;
            //Console.WriteLine("This numbers are requred:");
            //for (num = 1; num <= 100; num++)
            //{
            //    if (num % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    if (num % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    if ((num % 3 == 0) && (num % 5 == 0))
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    Console.WriteLine(num);
            //}
            //Console.ReadLine();
            #endregion
        }   
    }
}
