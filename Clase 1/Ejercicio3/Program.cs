using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lectura;
            int aux = 0;
            int i = 0;
            bool parse = true;
            string salir;
             
            do
            {
                Console.WriteLine("Por favor ingrese un numero:");
                lectura = Console.ReadLine();

                if (lectura != "salir")
                {
                    parse = int.TryParse(lectura, out aux);
                    if (!parse || aux < 0)
                    {
                        Console.WriteLine("ERROR. Reingrese un numero valido.");
                    }
                }
                else
                {
                    Console.WriteLine("Desea continuar? si/no");
                    salir = Console.ReadLine();
                    if(salir=="si")
                    { 
                    break;
                    }
                }
            } while (parse == false);

            if (lectura != "salir")
            {
                for (int j = 2; j <= aux; j++)
                {
                    for (i = 2; i < j; i++)
                    {
                        if ((j % i) == 0)
                        {
                            break;
                        }
                    }

                    if (i == j)
                    {
                        Console.WriteLine("{0} es primo", j);
                    }

                }

            }

            
        }


    }
}

