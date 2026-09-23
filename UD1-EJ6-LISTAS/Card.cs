using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ6_LISTAS
{
    internal class Card
    {
        public enum CategoryCard { Bronce,Plata,Oro}

        public CategoryCard MyCategoryCard { get; set; }
        public int NumberCard { get; set; }
        public string NameCard { get; set; }

        public Card() { }

        public Card(int number, string name, CategoryCard category)
        {
            NumberCard = number;
            NameCard = name;
            MyCategoryCard = category;

        }

        

    }
}
