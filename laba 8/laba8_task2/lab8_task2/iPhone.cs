using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Petrenko_Eduard_PD-22
namespace lab8_task2
{
    class iPhone : ColorScreenPhone
    {
        public override void Call()
        {
            Console.WriteLine("Well");
        }
        public override void RingTone()
        {
            Console.WriteLine("*plays a song*");
        }
        public override void SurfTheNet()
        {
            Console.WriteLine("We're using wi-fi and 4g.");
        }
    }
}
