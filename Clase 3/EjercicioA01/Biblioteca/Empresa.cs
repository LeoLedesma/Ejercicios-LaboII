using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Empresa
    {
        public static Conductor GetConductorMasKmSemana(Conductor[] conductores)
        {
            int maxKm = 0;
            int i = 0;
            int index = 0;

            foreach (Conductor conductor in conductores)
            {
                if (conductor.GetKmTotales() > maxKm)
                {
                    maxKm = conductor.GetKmTotales();
                    index = i;
                }
                i++;
            }

            return conductores[index];

        }

        public static Conductor GetConductorMasKmDia(Conductor[] conductores, int dia)
        {
            int maxKm = 0;
            int i = 0;
            int index = 0;

            foreach (Conductor conductor in conductores)
            {
                if (conductor.GetKmDia(dia) > maxKm)
                { 
                    maxKm = conductor.GetKmDia(dia);
                    index = i;
                }
                i++;
            }

            return conductores[index];

        }

    }
}
