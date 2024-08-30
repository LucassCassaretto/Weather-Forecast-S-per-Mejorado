using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Forecast_Mejorado
{
    internal class Pasante : Persona
    {
        public int Legajo { get; set; }

        public Pasante() { }
        public Pasante(int legajo)
        {
            this.Legajo = legajo;
        }


        public void MostrarPasante()
        {
            Console.WriteLine($"Nombre: {Nombre}, Apellido: {Apellido}, Dni: {Dni}, Legajo: {Legajo}");
        }
    }
}
