using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia___Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lecturaA;
            string lecturaB;
            int anioInicio;
            int anioFin;

            do
            {
                Console.Clear();
                Console.Write("Por favor ingrese un año de inicio para buscar años bisiestos: ");
                lecturaA = Console.ReadLine();
                Console.Write("Por favor ingrese un año de fin para buscar años bisiestos: ");
                lecturaB = Console.ReadLine();

            } while (!int.TryParse(lecturaA, out anioInicio) || !int.TryParse(lecturaB, out anioFin) || anioFin<anioInicio);

            for (int i = anioInicio; i <= anioFin; i++)
            {
                if ((i % 4 == 0 && i % 100 != 0) || (i % 100 == 0 && i % 400 == 0))
                {
                    Console.WriteLine(i + " es año bisiesto.");
                }
            }
        }       
    }
}
