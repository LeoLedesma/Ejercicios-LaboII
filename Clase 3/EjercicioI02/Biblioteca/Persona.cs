namespace Biblioteca
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public void SetFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public DateTime GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }

        public void SetDni (int dni)
        {
            this.dni=dni;
        }

        public int GetDni()
        {
            return this.dni;
        }

        private int CalcularEdad()
        {
            DateTime hoy = DateTime.Now;
            int edad = hoy.Year - this.fechaDeNacimiento.Year;

            
            if(hoy.DayOfYear<this.fechaDeNacimiento.DayOfYear)
            {
                edad--;
            }

            return edad;
        }

        public string Mostrar()
        {
            return $"Nombre: {this.nombre}, edad: {this.CalcularEdad()}, fecha de nacimiento: {this.fechaDeNacimiento.ToString("dd/MM/yy")}, dni: {this.dni}";
        }

        public string EsMayorDeEdad()
        {
            return this.CalcularEdad() >= 18 ? "Es mayor de edad" : "es menor";
        }
    }
}