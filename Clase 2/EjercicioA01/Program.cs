using LogicaDeNegocio;

int numeroIngresado;
string auxiliarString;

do
{
    Console.WriteLine("Por favor ingrese el numero del que desea conocer su factorial");
    auxiliarString = Console.ReadLine();
} while (!int.TryParse(auxiliarString, out numeroIngresado));

Console.WriteLine("El resultado es: {0:#,##}", Calculadora.Factoriar(numeroIngresado));





