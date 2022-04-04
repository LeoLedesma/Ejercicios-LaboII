using System.Text;

namespace Entidades
{
    public class Estudiante
    {

        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
              random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.legajo = legajo;
            this.apellido = apellido;
        }

        public void SetNotaPrimerParcial(int value)
        {
            this.notaPrimerParcial = value;
        }
        
        public void SetNotaSegundoParcial(int value)
        {
            this.notaSegundoParcial = value;
        }

        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        public double CalcularNotaFinal()
        {
            if(this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                return random.Next(6, 11);
            }else
            {
                return -1;
            }
           
        }

        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendLine($"Nombre: {this.nombre}, Apellido, {this.apellido}, Legajo: {this.legajo}");
            mensaje.AppendLine($"Nota primer parcial: {this.notaPrimerParcial}, Nota segundo parcial: {this.notaSegundoParcial}");
            mensaje.AppendLine($"Promedio: {this.CalcularPromedio()}");
            double notaFinal = this.CalcularNotaFinal();
            if(notaFinal!=-1)
            {
                mensaje.AppendLine($"Nota final: {notaFinal}");
            }else
            {
                mensaje.AppendLine($"Alumno desaprobado");
            }

            return mensaje.ToString();
        }

    }
}