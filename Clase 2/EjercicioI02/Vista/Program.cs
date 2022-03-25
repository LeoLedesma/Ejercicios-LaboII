// See https://aka.ms/new-console-template for more information
using LogicaDeNegocio;

string auxiliarString;
double numeroIngresado;
double resultado = 0;


Console.WriteLine("         Bienvenidos al programa sumador!        ");

do
{
    Console.WriteLine("Por favor ingrese un numero para sumar: ");
    auxiliarString = Console.ReadLine();

    while (!double.TryParse(auxiliarString, out numeroIngresado))
    {
        Console.WriteLine("ERROR. Por favor ingrese un numero para sumar: ");
        auxiliarString = Console.ReadLine();
    }

    resultado += numeroIngresado;
    Console.WriteLine("El resultado parcial es: {0}", resultado);

} while (Validador.ValidarRespuesta());

Console.Clear();
Console.WriteLine("El resultado final es: {0}", resultado);





