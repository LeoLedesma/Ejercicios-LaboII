using System;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valorHora;
            string nombre;
            int antiguedad;
            int cantidadHorasTrabajadas;
            int cantidadEmpleados;
            decimal importeCobrar;
            decimal importeBruto;
            string aux;
            string recibosSueldo = "";

            do
            {
                Console.Write("Ingrese la cantidad de empleados que quiere presentar: ");
                aux = Console.ReadLine();

            } while (!int.TryParse(aux, out cantidadEmpleados));

            for (int i = 0; i < cantidadEmpleados; i++)
            {
                Console.Clear();
                Console.WriteLine("Empleado n° {0} ", i+1);
                do
                {
                    Console.Write("Ingrese el valor de la hora: ");
                    aux = Console.ReadLine();

                } while (!decimal.TryParse(aux, out valorHora));

                Console.Write("Por favor ingrese el nombre del empleado: ");
                nombre = Console.ReadLine();

                do
                {
                    Console.Write("Ingrese la antiguedad: ");
                    aux = Console.ReadLine();

                } while (!int.TryParse(aux, out antiguedad));

                do
                {
                    Console.Write("Ingrese la cantidad de horas trabajadas: ");
                    aux = Console.ReadLine();

                } while (!int.TryParse(aux, out cantidadHorasTrabajadas));

                importeBruto = ((valorHora * cantidadHorasTrabajadas) + (antiguedad * 150));
                importeCobrar =  importeBruto * 0.87m;
                recibosSueldo += $"Nombre: {nombre}, Antiguedad: {antiguedad}, valor hora: {valorHora}, importe bruto: {importeBruto}, importe neto: {importeCobrar}.\n";
            }
            Console.Clear();
            Console.WriteLine(recibosSueldo);

        }
    }
}
