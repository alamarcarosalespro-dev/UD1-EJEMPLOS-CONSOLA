using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UD1_EJ5_EXCEPCIONES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //CREACIÓN DE UN FICHERO DE TEXTO
                string pathfile = @"C:\Users\Alberto\Documents\ficheros\fichero1.txt";
                StreamWriter myfile = File.CreateText(pathfile);
                myfile.WriteLine("Ejemplo de excepciones del tema1");
                myfile.WriteLine("Ejemplo 5.Miércoles 23 de Septiembre de 2026.");
                myfile.Close();

                StreamReader fileReader = new StreamReader(pathfile);
                string text = fileReader.ReadToEnd();
                Console.WriteLine(text);
                fileReader.Close();


            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("Error al no encontrarse el fichero:" + ex.Message);
            }
            catch(UnauthorizedAccessException ex)
            {
                Console.WriteLine("Error de permisos de la carpeta:" + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al trabajar con el fichero:" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Ejecutamos este código siempre");
            }

        }
    }
}
