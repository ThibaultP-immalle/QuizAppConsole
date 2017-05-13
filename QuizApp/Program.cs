using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var vragen = new List<Vraag>()
            {
                new Vraag { Inhoud = "Hoeveel is 1 + 1?", CorrectAntwoord = "2" },
                new Vraag { Inhoud = "Hoeveel is 2 * 3?", CorrectAntwoord = "6" }
            };

            foreach(var vraag in vragen)
            {
                vraag.StelVraag();
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Resultaat");
            Console.WriteLine("---------");
            Console.WriteLine();
            foreach(var vraag in vragen)
            {
                if(vraag.Check())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(vraag.Inhoud);
                    Console.WriteLine("\t\tCorrect!");
                } else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(vraag.Inhoud);
                    Console.WriteLine("\t\tFout: [{0}]", vraag.CorrectAntwoord);
                }
            }
            Console.ResetColor();
        }
    }
}
