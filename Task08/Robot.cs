using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    public class Robot : IWalkable
    {
        
        void IWalkable.Walk()
        {
            Console.WriteLine("Robot walking using IWalkable.");
        }

        
        public void Walk()
        {
            Console.WriteLine("Robot Walk method");
        }
    }
}
