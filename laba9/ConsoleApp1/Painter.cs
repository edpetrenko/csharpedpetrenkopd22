using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Petrenko_Eduard_PD-22
namespace ConsoleApp1
{
    static class Painter
    {
        public static void Draw(IDraw shape) { 
            shape.Draw();
        }
    }
}
