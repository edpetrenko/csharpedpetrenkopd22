using System;
using System.Drawing;
//Petrenko_Eduard_PD-22
namespace ConsoleApp1
{
    abstract class Shape 
    {

        public abstract string Name { get; }
        public abstract string FigureColor { get; set; }
        public abstract int NumOfVertices { get;}

        public abstract double Square();
        public abstract double Perimeter();      

        protected string RandomColor()
        {
            Random randomGen = new Random();
            KnownColor[] names = (KnownColor[])Enum.GetValues(typeof(KnownColor));
            KnownColor randomColorName = names[randomGen.Next(names.Length)];
            Color randomColor = Color.FromKnownColor(randomColorName);

            return randomColor.Name;
        }
    }
}
