using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_22
{
    internal class Circle:Shape
    {
        public int Radius;

        public override double CalculatedArea()
        {
            return Radius*Radius;
        }
    }
}
