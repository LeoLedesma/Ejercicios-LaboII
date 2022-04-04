using Biblioteca;

Persona persona1 = new Persona("Leonel", new DateTime(2000, 02, 10), 15269878);
Persona persona2 = new Persona("Micaela", new DateTime(2001, 12, 24), 15269879);
Persona persona3 = new Persona("Exequiel", new DateTime(1994, 04, 21), 15269876);

Console.WriteLine(persona1.Mostrar());
Console.WriteLine(persona2.Mostrar());
Console.WriteLine(persona3.Mostrar());

Console.WriteLine(persona1.EsMayorDeEdad());
Console.WriteLine(persona2.EsMayorDeEdad());
Console.WriteLine(persona3.EsMayorDeEdad());