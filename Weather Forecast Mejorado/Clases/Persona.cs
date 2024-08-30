using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Forecast_Mejorado
{
    internal class Persona
    {

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }


        public Persona() { }

        public Persona(string nombre, string persona, int dni)
        {
            this.Nombre = nombre;
            this.Apellido = persona;
            this.Dni = dni;
        }

    }
}
