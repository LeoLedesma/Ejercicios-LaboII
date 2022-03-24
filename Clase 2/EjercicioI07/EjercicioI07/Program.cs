using LogicaDeNegocio;

string auxiliarString;
double catetoA;
double catetoB;
double hipotenusa;

Console.WriteLine("Bienvenidos al calculo del teorema de pitagoras.\n" +
    " Recuerde que para un calculo correcto, el triangulo debe tener uno de sus angulos rectos (90°)");

do
{
    Console.WriteLine("\nPor favor ingrese la base del triangulo (cateto A): ");
    auxiliarString = Console.ReadLine();
} while(!double.TryParse(auxiliarString, out catetoA));

do
{
    Console.WriteLine("\nPor favor ingrese la altura del triangulo (cateto B): ");
    auxiliarString = Console.ReadLine();
} while (!double.TryParse(auxiliarString, out catetoB));

hipotenusa = Calculadora.CalcularTeoremaDePitagoras(catetoA, catetoB);
Console.WriteLine($"La hipotenusa del triangulo con base {catetoA} y altura {catetoB} es de {hipotenusa:#.###}");

