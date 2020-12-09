using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Petrenko_Eduard_PD-22
namespace lab8_task2
{
    class BlackWhitePhone : ButtonPhone
    {
        public bool display = true;
        public override void Call()
        {
            Console.WriteLine("I can call and not only this.");
        }

        public override void RingTone()
        {
            Console.WriteLine("*plays familiar to everyoneringtone * ");
        }
    }
}
