namespace Biblioteca
{
    public class Conductor
    {
        private string nombre;
        private int[] kmRecorridosSemana;


        public Conductor(string nombre, int[] kmRecorridosSemana)
        {
            this.nombre = nombre;
            this.kmRecorridosSemana = kmRecorridosSemana;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public int GetKmDia(int dia)
        {
            return this.kmRecorridosSemana[dia - 1];
        }

        public int GetKmTotales()
        {
            int acumulador = 0;

            for (int i = 0; i < this.kmRecorridosSemana.Length; i++)
            {
                acumulador += this.kmRecorridosSemana[i];
            }
            return acumulador;
        }

        public void SetKmDia(int kmRecorridos, int dia)
        {
            if (kmRecorridos >= 0)
            {
                this.kmRecorridosSemana[dia - 1] = kmRecorridos;
            }
        }
    }
}

