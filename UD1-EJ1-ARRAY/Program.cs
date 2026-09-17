using System;

namespace UD1_EJ1_ARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de variables
            String[] people = new String[3];
            int count = 0;

            //Pedimos al usuario datos de entrada
            while (count < people.Length)
            {
              //  Console.WriteLine("Escribe la palabra número "+(count+1));
                Console.WriteLine($"Escribe la palabra número {count+1}: ");
                people[count] = Console.ReadLine();
                count++;
            }

            //Mostramos los datos de nuevo
            foreach (string i in people)
            {
                Console.WriteLine(i);
            }
                
        }
    }
}
