using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Forecast_Mejorado
{
    internal class Profesional : Persona
    {
        public int Matricula { get; set; }

        public Profesional() { }
        public Profesional(int matricula)
        {
            this.Matricula = matricula;
        }
    }
}
