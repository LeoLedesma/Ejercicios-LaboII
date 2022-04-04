using Entidades;

Sumador sumador = new Sumador();
Sumador sumador2 = new Sumador(2);
Sumador sumador3 = new Sumador(10);

Console.WriteLine($"La suma de dos long {sumador.Sumar(45, 2)}");
Console.WriteLine($"La suma de dos string {sumador.Sumar("Hola ", "Mundo")}");

int cantidadSumas = (int)sumador;
Console.WriteLine(cantidadSumas);

Console.WriteLine(sumador + sumador2);
Console.WriteLine(sumador | sumador2);
Console.WriteLine(sumador | sumador3);
