using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej4_Interfaces
{
    internal class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Coche arrancando.");
        }

        public void Stop()
        {
            Console.WriteLine("Coche frenando.");
        }

        public void Acelerate()
        {
            Console.WriteLine("Coche acelerando.");
        }
    }
}
