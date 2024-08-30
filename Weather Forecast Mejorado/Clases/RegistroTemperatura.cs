using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Forecast_Mejorado
{
    internal class RegistroTemperatura
    {
        public double TemperaturaRegistrada { get; set; }
        public DateOnly FechaRegistro { get; set; }
        public TimeOnly HoraRegistro { get; set; }
        public Pasante? Pasante { get; set; }
        public Profesional? Profesional { get; set; }


        public RegistroTemperatura()
        {

        }

        public RegistroTemperatura(double temp, DateOnly fecha, TimeOnly hora, Pasante? pasante, Profesional? profesional)
        {
            this.TemperaturaRegistrada = temp;
            this.FechaRegistro = fecha;
            this.HoraRegistro = hora;
            this.Pasante = pasante;
            this.Profesional = profesional;
        }


        public void CargarRegistro(Profesional? pro, Pasante? pas)
        {
            Console.WriteLine("Ingrese temperatura:");
            TemperaturaRegistrada = double.Parse(Console.ReadLine());

            if (pro != null)
            {
                Profesional = pro;
                Console.WriteLine("El profesional de turno es " + pro.Nombre + " su Matricula es: " + pro.Matricula);

            }
            else if (pas != null)
            {
                Pasante = pas;
                Console.WriteLine("El pasante de turno es " + pas.Nombre + " su Matricula es: " + pas.Legajo);
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


        public void mostrar()
        {
            Console.WriteLine($"\nTemperatura Registrada: {TemperaturaRegistrada}, Fecha de Registro: {FechaRegistro.ToShortDateString()}, Hora de registro: {HoraRegistro.ToShortTimeString()}");
            if (Pasante != null)
            {
                Console.WriteLine($"Pasante: {Pasante.Nombre}, Legajo: {Pasante.Legajo}");
            }
            else if (Profesional != null)
            {
                Console.WriteLine($"Profesional: {Profesional.Nombre}, Matriucula: {Profesional.Matricula}");
            }
            else
            {
                Console.WriteLine("No se registró ni pasante ni profesional.");
            }
        }

    }
}
