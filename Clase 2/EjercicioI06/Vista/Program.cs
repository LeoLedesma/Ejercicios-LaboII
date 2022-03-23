using LogicaDeNegocio;

string figura;
bool error = false;
double baseTriangulo;
double altura;
double longitudLado;
double radio;
string primerAuxiliarString;
string segundoAuxiliarString;
double areaCalculada = 0;

do
{
    Console.WriteLine("Por favor ingrese el area de que figura quiere calcular: ");
    Console.WriteLine(" - Triangulo\n - Cuadrado\n - circulo");
    Console.WriteLine("Escriba la opcion:");
    figura = Console.ReadLine().ToLower();

    Console.Clear();
    switch (figura)
    {
        case "triangulo":
            Console.WriteLine("Por favor ingrese la medida de la base del triangulo: ");
            primerAuxiliarString = Console.ReadLine();
            Console.WriteLine("Por favor ingrese la medida la altura del triangulo: ");
            segundoAuxiliarString = Console.ReadLine();

            if (double.TryParse(primerAuxiliarString, out baseTriangulo) && double.TryParse(segundoAuxiliarString, out altura))
            {
                areaCalculada = CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, altura);
            }

            break;
        case "cuadrado":
            Console.WriteLine("Por favor ingrese la longitud de uno de los lados del cuadrado: ");
            primerAuxiliarString = Console.ReadLine();

            if (double.TryParse(primerAuxiliarString, out longitudLado))
            {
                areaCalculada = CalculadoraDeArea.CalcularAreaCuadrado(longitudLado);
            }

            break;
        case "circulo":
            Console.WriteLine("Por favor ingrese el radio del circulo: ");
            primerAuxiliarString = Console.ReadLine();

            if (double.TryParse(primerAuxiliarString, out radio))
            {
                areaCalculada = CalculadoraDeArea.CalcularAreaCirculo(radio);
            }
            break;
            default:
            Console.WriteLine("ERROR. No ingreso una opcion correcta, intente nuevamente");
            error = true;
            break;
    }
} while (error) ;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\n\nEl area del {figura} es: {areaCalculada}");
Console.ForegroundColor = ConsoleColor.White;



