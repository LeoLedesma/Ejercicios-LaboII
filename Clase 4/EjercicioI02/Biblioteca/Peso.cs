namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Peso()
        {
            cotzRespectoDolar = 102.65;
        }

        public Peso(double cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad = cantidad;
            }
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }

        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            return p.GetCantidad() == ((Peso)d).GetCantidad();
        }

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            return p.GetCantidad() == ((Peso)e).GetCantidad();
        }

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }
                       
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }
        
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }


        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.cantidad / Peso.GetCotizacion());
        }

        public static explicit operator Euro(Peso p)
        {
            return new Euro(((Dolar) p).GetCantidad() / Euro.GetCotizacion());
        }

        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }


        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad() - ((Peso)d).GetCantidad());
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad() - ((Peso)e).GetCantidad());
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad() + ((Peso)d).GetCantidad());
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(e.GetCantidad() + ((Peso)e).GetCantidad());
        }


    }
}