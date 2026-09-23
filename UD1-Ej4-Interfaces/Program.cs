using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD1_Ej4_Interfaces;

namespace UD1_EJ4_INTERFACES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicle car1 = new Car();
            Car car2 = new Car();
            IVehicle motorbike1 = new MotorBike();

            car1.Start();

            car2.Acelerate();
            motorbike1.Stop();

        }
    }
}
