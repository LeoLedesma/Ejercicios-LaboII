using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresado;
            long sumaAntes;
            long sumaDespues;

            Console.Write("Por favor ingrese hasta que numero quiere buscar un centro numerico: ");
            numeroIngresado = Console.ReadLine();

            if (int.TryParse(numeroIngresado, out int numero))
            {

                for (int i = 1; i < numero; i++) //i = numeroActual
                {
                    sumaAntes = 0;
                    sumaDespues = 0;

                    for (int j = 0; j < i; j++) //Sumo numeros anteriores
                    {
                        sumaAntes += j;
                    }

                    for (int k = i + 1; sumaDespues <= sumaAntes; k++)//Sumo numeros posteriores y comparo
                    {
                        sumaDespues += k;
                        if (sumaDespues == sumaAntes)
                        {
                            Console.WriteLine("{0} es un centro numerico.", i);
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("No hemos encontrado mas centros numericos hasta el {0}", numero);
        }
    }
}
