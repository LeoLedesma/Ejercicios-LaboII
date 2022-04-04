using Billetes;
//inicializo

Dolar cuentaDolares = new Dolar(100); //
Peso cuentaPesos = new Peso(150);
Euro cuentaEuros = new Euro(150);

Console.WriteLine($"{cuentaPesos.GetCantidad()} pesos = {((Dolar) cuentaPesos).GetCantidad()} dolares");
Console.WriteLine($"{cuentaPesos.GetCantidad()} pesos = {((Euro) cuentaPesos).GetCantidad()} euro");

Console.WriteLine($"{cuentaDolares.GetCantidad()} dolares = {((Euro) cuentaDolares).GetCantidad()} euros");
Console.WriteLine($"{cuentaDolares.GetCantidad()} dolares = {((Peso)cuentaDolares).GetCantidad()} pesos");

Console.WriteLine($"{cuentaEuros.GetCantidad()} euros = {((Dolar) cuentaEuros).GetCantidad()} dolares");
Console.WriteLine($"{cuentaEuros.GetCantidad()} euros = {((Peso) cuentaEuros).GetCantidad()} pesos");

Console.WriteLine((cuentaEuros-cuentaDolares).GetCantidad());
Console.WriteLine((cuentaEuros-cuentaPesos).GetCantidad());

