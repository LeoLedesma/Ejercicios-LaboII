using Logica;
using System;

int numeroIngresado;
int numeroMaximo = int.MinValue;
int numeroMinimo = int.MaxValue;
int acumulador = 0;
string auxiliarString;
bool parseado;
bool validado;
float promedio;

for (int i = 0; i < 10; i++)
{
    do
    {
        Console.WriteLine("Por favor ingrese un numero: ");

        auxiliarString = Console.ReadLine();
        parseado = int.TryParse(auxiliarString, out numeroIngresado);
        validado = parseado ? Validador.Validar(numeroIngresado, -100, 100) : false;        

        if (!validado)
        {
            Console.Write("ERROR. ");
        }

    } while(!validado);

    if(numeroIngresado > numeroMaximo)
    {
        numeroMaximo = numeroIngresado;        
    }else if(numeroIngresado < numeroMinimo)
    {
        numeroMinimo = numeroIngresado;
    }

    acumulador += numeroIngresado;
}

promedio = (float) acumulador / 10;

Console.WriteLine($"El valor minimo ingresado es: {numeroMinimo}\nEl valor maximo ingresado es: {numeroMaximo}\nEl promedio de todos los numeros es: {promedio}");


