using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadAMostrar = 4;
            int numerosMostrados = 0;
            int numero = 1;
            int sumaDivisores;

            while (numerosMostrados < cantidadAMostrar)
            {
                sumaDivisores = 0;
                for (int i = 0; i < numero; i++)
                {
                    if (i != 0 && numero % i == 0)
                    {
                        sumaDivisores += i;
                    }
                }

                if (numero == sumaDivisores)
                {
                    Console.WriteLine(numero + " es un numero perfecto.");
                    numerosMostrados++;
                }
                numero++;
            }
        }
    }
}
