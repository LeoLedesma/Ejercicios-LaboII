using Entidades;

Estudiante alumno1 = new Estudiante("Leonel", "Ledesma", "00001");
Estudiante alumno2 = new Estudiante("Micaela", "Schlemender", "00002");
Estudiante alumno3 = new Estudiante("Exequiel", "Ledesma", "00000");

alumno1.SetNotaPrimerParcial(8);
alumno2.SetNotaPrimerParcial(10);
alumno3.SetNotaPrimerParcial(3);

alumno1.SetNotaSegundoParcial(6);
alumno2.SetNotaSegundoParcial(7);
alumno3.SetNotaSegundoParcial(2);

Console.WriteLine(alumno1.Mostrar());
Console.WriteLine(alumno2.Mostrar());
Console.WriteLine(alumno3.Mostrar());

