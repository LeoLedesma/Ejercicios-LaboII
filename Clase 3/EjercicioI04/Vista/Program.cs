using Biblioteca;

Boligrafo tintaAzul = new Boligrafo(100, ConsoleColor.Blue);
Boligrafo tintaRoja = new Boligrafo(10, ConsoleColor.Red);
string salida;

Console.WriteLine(tintaRoja.GetTinta());
Console.WriteLine(tintaRoja.GetColor());
tintaRoja.Pintar(8, out salida);
tintaAzul.Pintar(6, out salida);
tintaRoja.Pintar(8, out salida);

Console.WriteLine("La cantidad de tinta es : " + tintaRoja.GetTinta());
tintaRoja.Recargar();
Console.WriteLine("La cantidad de tinta es : " + tintaRoja.GetTinta());
