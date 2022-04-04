using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice3 = vertice3;
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
        }

        public float Area()
        {
            if (this.area == 0)
            {
                float baseRectangulo = Math.Abs(this.vertice1.GetX() - this.vertice2.GetX());
                float alturaRectangulo = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
                this.area = baseRectangulo * alturaRectangulo;
                return this.area;
            }
            else
            {
                return this.area;
            }
        }

        public float Perimetro()
        {
            float distanciaZ = Math.Abs(this.vertice1.GetX() - this.vertice2.GetX());
            float distanciaY = Math.Abs(this.vertice2.GetY() - this.vertice3.GetY());

            return (distanciaY + distanciaZ) * 2;
        }

        public static string Mostrar(Rectangulo r)
        {
            return ($"Area del rectangulo: {r.Area()}, perimetro: {r.Perimetro()}");
        }


    }
}
