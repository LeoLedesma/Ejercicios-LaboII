﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            cotzRespectoDolar = (1 / 1.17); //1 euro = 1.17 dolares, cotizacion = 1euro /1.17 dolares
        }
        public Euro(double cantidad)
        {
           this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
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


        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad() * Euro.GetCotizacion());
        }
        public static explicit operator Peso(Euro e)
        {
            return new Peso(((Dolar)e).GetCantidad() * Peso.GetCotizacion());
        }
        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }



        public static bool operator ==(Euro e, Dolar d)
        {
            return d.GetCantidad() == ((Dolar)e).GetCantidad();
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(d == e);
        }

        public static bool operator ==(Euro e, Peso p)
        {

            return e.GetCantidad() == ((Euro)p).GetCantidad();
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());
        }

        public static Euro operator +(Euro e1, Euro e2)
        {
            return new Euro(e1.GetCantidad() + e2.GetCantidad());
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad() + ((Euro)p).GetCantidad());
        }


    }
}
