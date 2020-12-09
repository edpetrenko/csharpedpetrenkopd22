using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Petrenko_Eduard_PD-22
namespace lab8_task2
{
    class DiskPhone
    {
         public bool calls = true;
         public int numOfDigits = 10;

        public virtual void Call()
        {
            Console.WriteLine("Hi!");
        }

        public virtual void RingTone()
        {
            Console.WriteLine("*bip-bip-bip*");
        }
    }
}
