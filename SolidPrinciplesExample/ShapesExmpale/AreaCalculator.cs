using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesExample.OpenClosedPrinciple
{
    public class AreaCalculator
    {
        public double TotalArea(Shape[] shapes)
        {
            double result = 0;
            foreach (Shape shape in shapes)
            {
                result += shape.Area();
            }
            return result;
        }
    }
}
