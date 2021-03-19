using System;

namespace Clase_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.DarkCyan;
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.Clear(); // 100% color de fondo

            Console.WriteLine("Hello World!");
            Console.WriteLine("Ingrese un nombre:");
            string nombre = Console.ReadLine().Trim();

            // "   hola" .TrimStar(); remueve los espacios del inicio
            // "hola   " .TrimEnda(); remueve los espacios del final

            //Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Ingrese la edad");
            string edadTx = Console.ReadLine();
            int edad = -1;
            bool esValido = Int32.TryParse(edadTx, out edad);

            if(!esValido)
                {
                    Console.WriteLine("Ingrese bien la edad");
                }
            else
                {
                    Console.WriteLine("Su nombre es : {0} y la edad que tiene es:  {1}", nombre, edadTx);
                }

            Console.ReadKey();
        }
    }
}