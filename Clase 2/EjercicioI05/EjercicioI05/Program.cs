using LogicaDeNegocio;

int numeroIngresado;
string auxiliarString;

do
{
    Console.WriteLine("Ingrese el numero que desea conocer la tabla de multiplicar: ");
    auxiliarString = Console.ReadLine();
} while(!int.TryParse(auxiliarString, out numeroIngresado));

Console.Clear();
Console.WriteLine(Calculadora.CrearTablaMultiplicar(numeroIngresado));





