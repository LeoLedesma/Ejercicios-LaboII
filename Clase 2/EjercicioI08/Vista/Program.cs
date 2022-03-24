// See https://aka.ms/new-console-template for more information
using LogicaDeNegocio;

string auxiliarString;
string[] date;
int day;
int month;
int year;
int diasVividos;


do
{
    Console.WriteLine("Ingrese la fecha de nacimiento con el siguiente formato: 10/02/2000");
    auxiliarString = Console.ReadLine();
    date = auxiliarString.Split("/");
    
}while(!int.TryParse(date[0], out day) & !int.TryParse(date[1], out month) & !int.TryParse(date[2], out year));

DateTime fechaIngresada = new DateTime(year, month, day);
diasVividos = Fechas.CalcularDiasEntreFechas(fechaIngresada);

Console.WriteLine($"La cantidad de dias vividos entre el {fechaIngresada.ToString("dd/MM/yyyy")} y hoy es de: {diasVividos}");
