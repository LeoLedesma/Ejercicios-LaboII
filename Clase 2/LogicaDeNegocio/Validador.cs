using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public static class Validador
    {
        public static bool ValidarRespuesta()
        {
            string respuesta;
            
            Console.WriteLine("¿Desea continuar? (S/N)");
            respuesta = Console.ReadLine().ToLower();

            return respuesta == "s";
        }

    }
}
