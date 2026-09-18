using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    public class Bike : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Bike Is Started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Bike Is Stoped");
        }
    }
}
