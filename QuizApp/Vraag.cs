using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Vraag
    {
        public string Inhoud { get; set; }
        public string CorrectAntwoord { get; set; }

        private string gegevenAntwoord;

        public virtual void StelVraag()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Inhoud);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Antwoord: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            gegevenAntwoord = Console.ReadLine();
            Console.ResetColor();
        }

        public bool Check()
        {
            if(gegevenAntwoord == CorrectAntwoord)
            {
                return true;
            }
            return false;
        }
    }
}
