using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    public abstract class Shape
    {
        public abstract double GetArea();

        public virtual void Display()
        {
            Console.WriteLine("This is a shape");
        }
    }
}
