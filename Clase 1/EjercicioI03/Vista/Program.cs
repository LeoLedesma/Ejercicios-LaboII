// See https://aka.ms/new-console-template for more information

string auxiliarString;
int numeroIngresado;
bool error;
string continuar = "si";
int j = 0;

do
{
    error = false;
    Console.WriteLine("Por favor ingrese un numero:");
    auxiliarString = Console.ReadLine();    

    if (!int.TryParse(auxiliarString, out numeroIngresado) || numeroIngresado <= 0)
    {
        Console.WriteLine("ERROR. Reingrese un numero valido. Desea continuar (si/no)?");
        continuar = Console.ReadLine().ToLower();
        error = true;
    }

} while (error && continuar=="si");

if(continuar=="si")
{
    Console.WriteLine("Los numeros primos hasta el numero {0} son: ", numeroIngresado);
    for (int i = 2; i <= numeroIngresado; i++)
    {
        for (j = 2; j < i; j++)
        {
            if ((i % j) == 0)
            {
                break;
            }
        }        

        if (j == i)
        {
            Console.Write("{0}, ", i);
        }

    }
}

