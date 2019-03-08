using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, e;
            Console.WriteLine("Please enter first number ..");

            string x = Console.ReadLine();
            a = Convert.ToInt32(x);
            Console.WriteLine(a);

            Console.WriteLine("Please enter second number ..");
            string y = Console.ReadLine();
            b = Convert.ToInt32(y);
            Console.WriteLine(b);

            Console.WriteLine("Please enter third number ..");
            string z = Console.ReadLine();
            c = Convert.ToInt32(z);
            Console.WriteLine(c);

            Console.WriteLine("Please enter last number ..");
            string o = Console.ReadLine();
            e = Convert.ToInt32(o);
            Console.WriteLine(e);

            int result = (a + b + c + e) / 4;
            Console.WriteLine("The average of " + a + ", " + b + ", " + c + " and " + e + " is: " + result);
            Console.ReadLine();
        }
    }
}
