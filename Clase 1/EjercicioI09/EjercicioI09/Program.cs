using System.Text;


int alto;
string auxiliarString;
int cantidadEspacios;
StringBuilder piramide = new StringBuilder();


do
{
    Console.WriteLine("Por favor ingrese la altura que quiera hacer la piramide: ");
    auxiliarString = Console.ReadLine();
} while (!int.TryParse(auxiliarString, out alto) || alto<=0);


cantidadEspacios = alto * 2;

for (int i = 1; i < alto * 2; i += 2)//Multiplico porque en cada linea quiero que se pongan 2 *
{
    piramide.Clear(); //Limpio la variable
    for (int j = 1; j <= i; j++)//i por cada iteracion aumenta 2 asteriscos
    {
        piramide.Append("*"); //Le agrego 2 * por iteracion de j
    }

    for (int k = 0; k < (cantidadEspacios); k++)
    {
        Console.Write(" "); //Hago los espacios suficientes
    }

    Console.WriteLine(piramide.ToString());
    cantidadEspacios--;
}
