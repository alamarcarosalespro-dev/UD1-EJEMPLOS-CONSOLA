using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ2_CLASE
{
    internal class Worker
    {
        public string Name { get; set; }

        private double _salary;
        public double Salary 
        {
          // get { return Salary; }
          get => _salary;
          set 
            {   if (value <= 0)
                {
                    Console.WriteLine($"Valor negativo.Ponemos el salario a cero.");
                   _salary = 0;
                }
                else
                {
                    _salary = value;
                }
                 }
        
        }

        //Constructor

        public Worker(string name)
        {
            Name = name;
        }

    }
}
