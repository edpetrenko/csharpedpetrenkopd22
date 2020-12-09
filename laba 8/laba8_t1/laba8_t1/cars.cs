using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Petrenko_Eduard_PD-22
namespace laba8_t1
{
    class car
    {
        public string Name { get; }
        public string Color { get; }
        public int Speed { get; }
        public int YearOfIssue { get; }

        public car() { }
        public car(string name, string color, int speed, int yearOfIssue)
        {
            Name = name;
            Color = color;
            Speed = speed;
            YearOfIssue = yearOfIssue;
        }
    }
}
