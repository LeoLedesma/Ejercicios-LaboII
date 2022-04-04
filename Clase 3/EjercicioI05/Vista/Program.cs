using Geometria;

Punto vertice1 = new Punto(0, 0);
Punto vertice3 = new Punto(10, 15);

Rectangulo rect = new Rectangulo(vertice1, vertice3);

Console.WriteLine($"x: {vertice1.GetX()}, y: {vertice1.GetY()}");
Console.WriteLine($"El area es: {rect.Area()}");
Console.WriteLine($"El perimetro es: {rect.Perimetro()}");

//Al hacerlo con net 6, no encuentro la forma de hacer exactamente lo que el punto dice del metodo Mostrar.
Console.WriteLine(Rectangulo.Mostrar(rect));

