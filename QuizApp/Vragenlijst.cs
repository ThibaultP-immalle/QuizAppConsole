using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Vragenlijst
    {
        List<Vraag> vragen = new List<Vraag>();

        public void VoegVraagToe(Vraag v)
        {
            vragen.Add(v);
        }

        public void Start()
        {            
            foreach (var v in vragen)
            {
                v.StelVraag();                
            }
        }

        public void PrintRapport()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Resultaat");
            Console.WriteLine("---------");
            Console.WriteLine();

            foreach (var vraag in vragen)
            {
                if (vraag.Check())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(vraag.Inhoud);
                    Console.WriteLine("\t\tCorrect!");
                }
                else
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
