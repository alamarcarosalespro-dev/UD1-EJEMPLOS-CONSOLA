using System;
using System.Collections.Generic;

namespace UD1_EJ6_LISTAS
{
    internal class Program
    {

        static List<Card> ListCard = new List<Card>();
        static void Main(string[] args)
        {
            //Vamos a crear un cromo y lo añadimos a la lista
            Card card1 = new Card(101, "Messi", Card.CategoryCard.Oro);

            ListCard.Add(card1);

            ListCard.Add(new Card(102,"Ronaldo",Card.CategoryCard.Bronce));

            //Mostrarlos por pantalla
            Console.ForegroundColor = ConsoleColor.Blue;


            CheckListCard();

            //Vamos a realizar otras operaciones
            List<Card> AuxList = new List<Card>()
            {
                new Card(103,"Ferrán Torres",Card.CategoryCard.Plata),
                new Card(104,"Neymar",Card.CategoryCard.Plata)
            };

            ListCard.Remove(card1);

            ListCard.AddRange(AuxList);

            Console.ForegroundColor = ConsoleColor.Red;

            CheckListCard();

            Console.ResetColor();
        }

        private static void CheckListCard()
        {
            foreach (var card in ListCard)
            {
                Console.WriteLine($"Número:{card.NumberCard}, nombre:{card.NameCard} y categoría {card.MyCategoryCard}");
            }
        }
    }
}
