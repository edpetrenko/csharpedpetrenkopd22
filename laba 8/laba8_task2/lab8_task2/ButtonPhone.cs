﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Petrenko_Eduard_PD-22
namespace lab8_task2
{
    class ButtonPhone : DiskPhone
    {
        
        public bool Buttons = true;

        public override void Call()
        {
            Console.WriteLine("I can call. L O L.");
        }

    }
}
