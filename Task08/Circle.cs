using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        #region Methods
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return 3.14 * Radius * Radius;
        }

        #endregion
    }
}
