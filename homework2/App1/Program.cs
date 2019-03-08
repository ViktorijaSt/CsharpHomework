using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is behind door number: 1, 2, 3 - please select your number..");


            string caseSwitch;
            caseSwitch = Console.ReadLine();
            int intSwitch = int.Parse(caseSwitch);
            switch (intSwitch)
            {
                case 1:
                    Console.WriteLine("You got a new car.");
                    break;
                case 2:
                    Console.WriteLine("You got a new plane.");
                    break;
                case 3:
                    Console.WriteLine("You got a new bike.");
                    break;
                default:
                    Console.WriteLine("no such option!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
