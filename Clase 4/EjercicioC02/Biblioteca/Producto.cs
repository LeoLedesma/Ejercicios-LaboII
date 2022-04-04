namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto(Producto p)
        {
            return $"Codigo de barra: {(string)p}, Marca: {p.marca}, Precio: {p.precio}";
        }

        //Sobrecarga operadores
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p, string marca)
        {
            return p.marca == marca;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p.marca == marca);
        }

        public static bool operator ==(Producto p, Producto p2)
        {
            return p.marca == p2.marca && (string)p == (string)p2;
        }

        public static bool operator !=(Producto p, Producto p2)
        {
            return !(p == p2);
        }
    }
}