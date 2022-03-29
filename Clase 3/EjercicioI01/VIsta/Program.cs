using Banco;

Cuenta cliente1 = new Cuenta("Leonel", 1000);
Console.WriteLine(cliente1.Mostrar());

cliente1.Ingresar(1500);
Console.WriteLine("El saldo actual es: {0}", cliente1.GetCantidad());

cliente1.Retirar(3000);
Console.WriteLine("El saldo actual es: {0}", cliente1.GetCantidad());





