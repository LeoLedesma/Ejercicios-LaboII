using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalNumerosALeer = 5;

            int max = 0;
            int min = 0;

            int acumulador = 0;
            float promedio;

            string lectura;

            for (int i = 0; i < totalNumerosALeer; i++)
            {
                Console.WriteLine("Por favor ingrese un numero:");
                lectura = Console.ReadLine();

                if (int.TryParse(lectura, out int aux))
                {
                    if (i == 0)
                    {
                        max = aux;
                        min = aux;
                    }

                    max = aux > max ? aux : max;
                    min = aux < min ? aux : min;

                    acumulador += aux;
                }
                else
                {
                    Console.WriteLine("ERROR. Por favor ingrese un numero valido:");
                    i--;
                }
            }

            promedio = (float)acumulador / totalNumerosALeer;

            Console.Clear();
            Console.WriteLine("El numero maximo ingresado es: {0}", max);
            Console.WriteLine("El numero minimo ingresado es: {0}", min);
            Console.WriteLine("El promedio de todos los numeros es: {0:#.##}", promedio); //Me muestra 00 y no me redondea
            Console.ReadKey();

        }
    }
}
