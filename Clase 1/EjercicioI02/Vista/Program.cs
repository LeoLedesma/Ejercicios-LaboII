// See https://aka.ms/new-console-template for more information

bool error;
int numeroIngresado;
string auxiliarString;

do
{
    error = false;
    Console.WriteLine("Ingrese el numero que quiera saber su cuadrado y su cubo: ");
    auxiliarString = Console.ReadLine();
    int.TryParse(auxiliarString, out numeroIngresado);   

    if (numeroIngresado<=0) //Al ingresar algo que no sea un numero, tryParse devuelve 0. Dando asi error tanto como si se ingresara 0 o inferior u otro caracter
    {
        Console.WriteLine("ERROR. ¡Reingresar número!");
        error = true;
    }
} while (error);

Console.WriteLine("El cuadrado de {0} es: {1}", numeroIngresado, Math.Pow(numeroIngresado, 2));
Console.WriteLine("El cubo de {0} es: {1}", numeroIngresado, Math.Pow(numeroIngresado, 3));






