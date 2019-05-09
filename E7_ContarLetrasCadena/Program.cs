using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace E7_StringCuantasLetras
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            string opcion;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingrese una cadena:");
                var cadena = Console.ReadLine();
                if (cadena.Length > 0)
                    Console.WriteLine("La cadena \"{0}\", tiene \"{1}\" letras", cadena, ContarLetras(cadena));
                else
                    Console.WriteLine("Cadena vacía");

                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("n : nueva, s : salir");
                    opcion = Console.ReadLine();

                    if (opcion.Equals("s"))
                    {
                        salir = true;
                        break;
                    }
                    else if (!opcion.Equals("n"))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No se reconoce opción");
                    }                        
                    else
                        break;
                } while (true);
                
            } while (!salir);
        }

        public static int ContarLetras(string cadena)
        {
            cadena = cadena.ToLower();
            int contador = 0;
            foreach (char x in cadena.ToArray())
                foreach(char c in letras)
                    if (x == c)
                        contador++;
            return contador;
        }

        public static char[] letras = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public static int ContarLetrasConRegex(string cadena)
        {
            MatchCollection matches = new Regex("[a-zA-Z]").Matches(cadena);           
            return matches.Count;
        }
    }
}
