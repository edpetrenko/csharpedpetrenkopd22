using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Petrenko_Eduard_PD-22
namespace lab8_task2
{
    class GoogleGlass : ColorScreenPhone
    {
        public int lenses = 2;

        public override void Call()
        {
            Console.WriteLine("Say \"Ok, Glass, ...\".\n ");
        }
        public override void RingTone()
        {
            Console.WriteLine("???");
        }
        public override void SurfTheNet()
        {
            Console.WriteLine("Browser.");
        }

    }
}
