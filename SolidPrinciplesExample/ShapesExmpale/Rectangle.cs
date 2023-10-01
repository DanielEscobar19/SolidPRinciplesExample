using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesExample.OpenClosedPrinciple
{
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public override double Area()
        {
            return this.Height * this.Width;
        }

        public double getHypotenuse()
        {
            var x = this.Height * this.Height;
            var y = this.Width * this.Width;

            return Math.Sqrt(x + y);
        }
    }

}
