using System.Text;

namespace LogicaDeNegocio
{
    public static class Calculadora
    {
        public static double Calcular(double primerOperando, double segundoOperando, string operacion)
        {
            double resultado = 0;
            switch (operacion)
            {
                case "+":
                    resultado = primerOperando + segundoOperando;
                    break;
                case "-":
                    resultado = primerOperando - segundoOperando;
                    break;
                case "/":
                    if (Validar(segundoOperando))
                    {
                        resultado = primerOperando / segundoOperando;
                    }else
                    {
                        Console.WriteLine("Error. No se puede dividir por cero.");
                    }
                    break;

                case "*":
                    resultado = primerOperando *segundoOperando;
                    break;

                default:
                    resultado = 0;
                    break;
            }

            return resultado;
        }

        private static bool Validar(double segundoOperando)
        {
            return segundoOperando != 0;
        }

        public static long Factoriar(int numero)
        {
            long resultado = 1;

            for(int i = numero; i > 1; i--)
            {
                resultado *= i;                
            }

            return resultado;
        }

        public static string CrearTablaMultiplicar(int numero)
        {
            StringBuilder tabla = new StringBuilder();
            double resultado;

            tabla.AppendLine($"Tabla de multiplicar del numero {numero}:");
            for(int i = 1; i <= 9; i++)
            {
                resultado = Calcular(numero, i, "*");
                tabla.AppendLine($"{numero} x {i} = {resultado}");
            }

            return tabla.ToString();
        }

    }

    
}