// See https://aka.ms/new-console-template for more information

int numeroIngresado;
string auxiliarString;

do
{
    Console.WriteLine("Por favor ingrese la altura que quiera hacer la piramide: ");
    auxiliarString = Console.ReadLine();

} while (!int.TryParse(auxiliarString, out numeroIngresado));

Console.Clear();
Console.WriteLine("*");

for (int i = 1; i < numeroIngresado; i++)
{
    Console.Write("*");
    for (int j = 0; j < i; j++)
    {
        Console.Write("**");
    }
    Console.WriteLine();
}
