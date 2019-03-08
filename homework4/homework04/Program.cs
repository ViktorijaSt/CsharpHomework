using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework04
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task01 

            //int inputNum, i;
            //i = 1;
            //Console.WriteLine("Please enter number on which you want to calculate the factorial:\n");
            //inputNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("Factorial from {0} is:  {1}.", inputNum, Factorial( inputNum, i));
            //Console.ReadLine();

            #endregion


            #region Task02


            #endregion

            ////Create datetime            
            //DateTime dt = new DateTime(2018, 02, 21, 18, 50, 23, 230);

            ////Example how it looks like in the output
            //var t = String.Format("{0:t}", dt); // "6:50 PM" ShortTime

            ////Console.WriteLine(t);
            //var d = String.Format("{0:d}", dt); //  21.2.2018 - DATUM
            //// Console.WriteLine(d);  
            //var T = String.Format("{0:T}", dt); // 18:50:23 - VREME SO SEKUNDI
            ////Console.WriteLine(T);
            //var D = String.Format("{0:D}", dt); //  среда, 21 февруари 2018 - DATUM SO DEN OD NEDELATA
            ////Console.WriteLine(D);
            //var f = String.Format("{0:f}", dt); // среда, 21 февруари 2018 18:50  - DATUM SO DEN OD NEDELATA I VREME
            ////Console.WriteLine(f);
            //var F = String.Format("{0:F}", dt); // "Wednesday, February 21, 2018 6:50:23 PM"
            ////Console.WriteLine(F);
            //var g = String.Format("{0:g}", dt); // 21.2.2018 18:50 - DIGITAL DATE I VREME
            ////Console.WriteLine(g);
            //var G = String.Format("{0:G}", dt); // 21.2.2018 18:50:23 - DIGITAL DATE I VREME SO SEKUNDI
            ////Console.WriteLine(G);
            //var m = String.Format("{0:m}", dt); // 21 февруари -  MESEC I DEN
            ////Console.WriteLine(m);
            //var y = String.Format("{0:y}", dt); // февруари 2018 г. - MESEC I GODINA
            ////Console.WriteLine(y);
            //var r = String.Format("{0:r}", dt); // Wed, 21 Feb 2018 18:50:23 GMT
            ////Console.WriteLine(r);            
            //var s = String.Format("{0:s}", dt); // 2018-02-21T18:50:23
            ////Console.WriteLine(s);           
            //var u = String.Format("{0:u}", dt); // 2018-02-21 18:50:23Z
            ////Console.WriteLine(u);
     

            //Console.WriteLine("--------------");

            //DateTime TimeNow = DateTime.Now;
            //DateTime TimeUtc = DateTime.UtcNow;
            //DateTime TimeToday = DateTime.Today;
            //Console.WriteLine("Current DateTime: {0} ", TimeNow);  	//Current DateTime: 07.3.2019 14:47:42
            //Console.WriteLine("UTC DateTime:     {0} ", TimeUtc);   //07.3.2019 13:48:36 UTC vreme i datum
            //Console.WriteLine("Today:            {0} ", TimeToday); // 07.3.2019 00:00:00
            //Console.WriteLine();

            //DateTime yesterday;
            //yesterday = TimeNow.AddDays(-1);

            //Console.WriteLine("Yesterday: {0}", yesterday);            //Yesterday: 06.3.2019 14:51:15
            //Console.WriteLine("The day before yesterday {0}", yesterday.TimeOfDay);//The day before yesterday 14:51:58.2577393          
            //Console.WriteLine("Minus 2 hours: {0}", TimeNow.AddHours(-2));  // Minus 2 hours: 07.3.2019 12:52:45           
            
            //int mDays = DateTime.DaysInMonth(2016, 2);
            //Console.WriteLine("Month Feb, 2016 has {0} days.", mDays);//Month Feb, 2016 has 29 days.
            //Console.WriteLine("Month Feb, 2018 has {0} days.", DateTime.DaysInMonth(2018, 2));//Month Feb, 2018 has 28 days.
            //Console.ReadLine();
            #region Task03

            //Console.Write("Number of words\n\n");
            //Console.WriteLine("Please enter some string: \n ");

            //string text = Console.ReadLine();
            //char[] separator = { ' ' };
            //int wordCount = text.Split(separator, StringSplitOptions.RemoveEmptyEntries).Length;

            //Console.WriteLine("\n Number of words in your text is {0}.", wordCount);
            //Console.ReadLine();



            //Console.WriteLine("................");


            //Console.Write("Number of empty spaces\n\n");
            //Console.WriteLine("Please enter some text: \n ");
            //string textInput = Console.ReadLine();

            //int count = 0;

            //foreach (char item in textInput)
            //{
            //    if (item == ' ')
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(" \n Number of empty spaces in your text is {0}.", count);
            //Console.ReadLine();


            //Console.WriteLine("................");
            //Console.Write("Effective length in a string including leading and trailing spaces\n\n");
            //Console.WriteLine("Please enter some text: \n ");
            //string tex = Console.ReadLine();

            //int sum = tex.Length;
            //Console.WriteLine(" \n Length of text is {0}.", sum);
            //Console.ReadLine();

            #endregion

            #region Factorial
            //static long Factorial(int inputNum, int i)
            //{
            //    int f = 1;
            //    for (i = 1; i <= inputNum; i++)

            //       f *= i;
            //    {
            //        return f;
            //    };
            #endregion
        }
    }
}
