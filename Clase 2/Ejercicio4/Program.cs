using LogicaDeNegocio;

double primerOperando;
double segundoOperando;
string operador;
string auxiliarOperandos;
string deseaContinuar;
double resultado;

do
{
    Console.Clear();

    do
    {
        Console.WriteLine("Por favor ingrese el primer operando: ");
        auxiliarOperandos = Console.ReadLine();

    } while (!double.TryParse(auxiliarOperandos, out primerOperando));

    do
    {
        Console.WriteLine("Por favor ingrese el operador (+, -, *, /): ");
        operador = Console.ReadLine();

    } while (operador != "/" && operador != "*" && operador != "-" && operador != "+");

    do
    {
        Console.WriteLine("Por favor ingrese el segundo operando: ");
        auxiliarOperandos = Console.ReadLine();
    } while (!double.TryParse(auxiliarOperandos, out segundoOperando));


    Console.Clear();

    resultado = Calculadora.Calcular(primerOperando, segundoOperando, operador);
    Console.WriteLine($"El resultado de la operacion {primerOperando} {operador} {segundoOperando} es: {resultado}");

    Console.WriteLine("¿Desea continuar con otra operacion? si/no ");
    deseaContinuar = Console.ReadLine().ToLower();

} while (deseaContinuar != "no");



