using Biblioteca;

int[] kmConductor1 = { 100, 300, 1000, 120, 1500, 1000, 500 }; //mas dia 5
int[] kmConductor2 = { 500, 1000, 1200, 1000, 1300, 890, 300 }; //mas totales
int[] kmConductor3 = { 100, 300, 2000, 120, 400, 989, 500 }; //mas dia 3

Conductor conductor1 = new Conductor("Leonel", kmConductor1);
Conductor conductor2 = new Conductor("Gustavo", kmConductor2);
Conductor conductor3 = new Conductor("Micaela", kmConductor3);

Conductor [] conductores = { conductor1, conductor2, conductor3 };

Console.WriteLine($"El conductor con mas km recorridos en la semana es: {(Empresa.GetConductorMasKmSemana(conductores)).GetNombre()}");
Console.WriteLine($"El conductor con mas km recorridos en el dia 3 es: {(Empresa.GetConductorMasKmDia(conductores, 3)).GetNombre()}");
Console.WriteLine($"El conductor con mas km recorridos en el dia 5 es: {(Empresa.GetConductorMasKmDia(conductores, 5)).GetNombre()}");




