using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Petrenko_Eduard_PD-22
namespace lab8_task2
{
    class ColorScreenPhone : BlackWhitePhone
    {
        public bool wifi = true;
        public override void Call()
        {
            Console.WriteLine("Easy.");
        }
        public override void RingTone()
        {
            Console.WriteLine("*plays a song*");
        }
        public virtual void SurfTheNet()
        {
            Console.WriteLine("Travel from wi-fi");
        }

    }
}
