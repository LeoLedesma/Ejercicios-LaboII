using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
            Console.WriteLine(productos.);
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {

            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            StringBuilder estante = new StringBuilder();
            Producto[] productos = e.GetProductos();

            estante.AppendLine($"El estante se encuentra en {e.ubicacionEstante} y sus productos son:");
            
            for(int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine(productos[i].ToString());
            }
            
            return estante.ToString();
        }
            
        public static bool operator ==(Estante e, Producto p)
        {
            return e.GetProductos().Contains(p);
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            if (e.productos.Length > e.GetProductos().Length && (e != p))
            {
                int ultimoProducto = e.productos.Length;
                e.productos[ultimoProducto] = p;
                return true;
            }
            else
            {
                return false;
            }

        }

        public static Estante operator -(Estante e, Producto p)
        {
            Producto[] listaDeProductos = e.GetProductos();

            for (int i = 0; i < listaDeProductos.Length; i++)
            {
                if (listaDeProductos[i] == p)
                {
                    listaDeProductos[i] = null;
                       e.productos = listaDeProductos;
                    return e;
                }
            }

            return e;
        }
    }
}
