using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aux;
            string lectura;

            do
            {
                Console.WriteLine("Por favor ingrese un numero:");
                lectura = Console.ReadLine();

                if (int.TryParse(lectura, out aux) && aux <=0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            } while (aux < 0);

            Console.Clear();
            Console.WriteLine(Math.Pow(aux, 2) + " es el cuadrado de {0}.", aux);
            Console.WriteLine(Math.Pow(aux, 3) + " es el cubo de {0}.", aux);
            Console.ReadKey();
        }
    }
}
