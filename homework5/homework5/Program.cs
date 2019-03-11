using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
    class Program
    {

        static void Main(string[] args)
        {
            Wizards[] magic = new Wizards[]
        {
                new Wizards("Kala", 60, 100, new DateTime(2231, 1, 9), false),
                new Wizards("Lena", 63, 41, new DateTime(2230, 1, 9), true),
                new Wizards("Maya", 55, 119, new DateTime(2240, 1, 9), false),
                new Wizards("Naya", 49, 202, new DateTime(2238, 1, 9), false),
                new Wizards("Freya", 61, 184, new DateTime(2233, 1,9), true),
        };
            Creatures[] student = new Creatures[]
            {
                new Creatures("Veda", 29, 111, false),
                new Creatures("Norman", 37, 75, true),
                new Creatures("David", 28, 37, false),
                new Creatures("Ana", 39, 42, false),
                new Creatures("Yura", 22, 28, false),
                new Creatures("Dreya", 30, 122, true),
            };
            Console.WriteLine("Which creature is tamed by the wizards?\n");
            Console.WriteLine("****************************************\n");
            int i, k;
            for (i = 0; i < magic.Length; i++)
            {
                for (k = 0; k < student.Length; k++)
                {
                    if (magic[i].PowerLevel > student[k].powerLevel)
                    {
                        Console.WriteLine("Wizard: {0} tamed creature-student: {1}.", 
                            magic[i].Name, student[k].name);
                        student[k].infoTamed = true;
                    }
                    else
                    {
                        Console.WriteLine("Wizard: {0} didn't tame creature-student: {1}.", 
                            magic[i].Name, student[k].name);
                    }

                    Console.ReadLine();
                }
            }
        }
    }
}   
     
