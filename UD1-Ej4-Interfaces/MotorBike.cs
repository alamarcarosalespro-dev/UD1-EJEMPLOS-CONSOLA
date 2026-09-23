using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_Ej4_Interfaces
{
    internal class MotorBike : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Moto arrancando.");
        }

        public void Stop()
        {
            Console.WriteLine("Moto frenando.");
        }

    }
}
