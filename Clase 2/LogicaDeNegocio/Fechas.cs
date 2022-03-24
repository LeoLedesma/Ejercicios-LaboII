using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeNegocio
{
    public class Fechas
    {
        public static int CalcularDiasEntreFechas(DateTime fechaIngresada)
        {            
            DateTime fechaActual = DateTime.Now;                                    
            return fechaActual.Subtract(fechaIngresada).Days;
        }


    }
}
