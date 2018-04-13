using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace QuizApp
{
    class TijdVraag : Vraag
    {
        TimeSpan AntwoordTijd { get; set; } = new TimeSpan();

        public override void StelVraag()
        {
            Timer t = new Timer();
        }       
    }
}
