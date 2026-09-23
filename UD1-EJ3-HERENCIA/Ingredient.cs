using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ3_HERENCIA
{
    internal class Ingredient
    {
        //PROPIEDADES
        public string Name { get; set; }

        public double Amount { get; set; } //en gramos

        public Ingredient(string name, double amount)
        {
            Name = name;
            Amount = amount;
        }

        //MÉTODO VIRTUAL PARA USAR EL POLIMORFISMO
        public virtual void Prepare()
        {
            Console.WriteLine($"Preparando la cantidad {Amount} de {Name}");
        }



    }
}
