using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    public class Rectangle : Shape
    {
        #region Propertes
        public double Width { get; set; }
        public double Height { get; set; }
        #endregion
        #region Methods
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double GetArea()
        {
            return Width * Height;
        } 
        #endregion

    }
}
