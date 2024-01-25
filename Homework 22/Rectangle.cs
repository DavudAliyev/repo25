using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Homework_22
{
    internal class Rectangle:Shape
    {
        public int Width;
        public int Height;
        public int Square;

        public override double CalculatedArea()
        {
            return Width * Height;
        }

        public double FindSquare()
        {
            if(Width==Height)
            {
                Square++;
            }
            return Square;
        }
    }
}
