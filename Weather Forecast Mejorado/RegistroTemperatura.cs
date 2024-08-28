using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Forecast_Mejorado
{
    internal class RegistroTemperatura
    {
        public double TemperaturaRegistrada {get; set;}
          public Persona persona {get; set;}
        public DateOnly FechaRegistro { get; set; }
        public TimeOnly HoraRegistro { get; set; }



        public RegistroTemperatura()
        {

        }

        public void CargarRegistro(Profesional? pro, Pasante? pas)
        {
            Console.WriteLine("Ingrese temperatura:");
            TemperaturaRegistrada = double.Parse(Console.ReadLine());

            if (pro != null)
            { 
                Console.WriteLine("El profesional de turno es " + pro.Nombre + "su Matricula es: " + pro.Matricula);
               
            }
            else if (pas != null)
            {
                Console.WriteLine("El pasante de turno es " + pas.Nombre + "su Matricula es: " + pas.Legajo);
            }
            else
            {
                Console.WriteLine("El metodo debe recibir si o si al menos un profesional o un pasante");
                return;
            }
            Console.WriteLine("Ingrese la fechas (año-mes-dia)");
            if (!DateOnly.TryParse(Console.ReadLine(), out DateOnly fechaRegistro))
            {
                Console.WriteLine("Fecha inválida. Intente nuevamente.");
                return;
            }

       
            Console.Write("Ingrese hora (formato Hora:Minutos): ");
            if (!TimeOnly.TryParse(Console.ReadLine(), out TimeOnly horaRegistro))
            {
                Console.WriteLine("Hora inválida. Intente nuevamente.");
                return;
            }
            FechaRegistro = fechaRegistro;
            HoraRegistro = horaRegistro;
        }

    }
}
