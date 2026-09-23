using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ3_HERENCIA
{
    internal class Meat : Ingredient
    {
        public string Type { get; set; }
        public Meat(string name, double amount,string type) : base(name, amount)
        {
            Type = type;
        }

        public override void Prepare()
        {
            base.Prepare();
            Console.WriteLine($"Carne preparada del tipo {Type}");
        }
    }
}
