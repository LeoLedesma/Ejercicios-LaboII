namespace Banco
{
    public class Cuenta
    {

        private string titular;
        private decimal cantidad;


        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            return $"El titular es: {this.titular} y el dinero actual es de: {this.cantidad}.";
        }

        public void Ingresar(decimal value)
        {
            if(value > 0)
            {
                this.cantidad += value;
            }
        }

        public void Retirar(decimal value)
        {
            this.cantidad -= value;
        }
    }
}