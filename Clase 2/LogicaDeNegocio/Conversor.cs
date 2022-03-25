using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public static class Conversor
    {
        public static string ConvertirDecimalABinario(int numero)
        {
            string binario = "";
            int auxiliarInt;
            string auxiliarString;

            do
            {
                auxiliarInt = numero % 2;
                numero = numero / 2;
                auxiliarString = auxiliarInt.ToString();
                binario = auxiliarString + binario;

            } while (numero > 0);

            return binario;
        }

        public static int ConvertirBinarioADecimal(int binario)
        {

            return binario;
        }


    }
}
