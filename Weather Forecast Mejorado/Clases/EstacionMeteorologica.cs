using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Weather_Forecast_Mejorado
{
    internal class EstacionMeteorologica
    {

        public RegistroTemperatura[,] RegistroTemp { get; set; }

        public EstacionMeteorologica()
        {
            RegistroTemp = new RegistroTemperatura[5,7];
        }




        public void RegistrarTemperatura(RegistroTemperatura reg)
        {

            int dia = reg.FechaRegistro.Day - 1;
            
            int semana = dia / 7;
            int diaSemana = dia % 7;
            if (semana < RegistroTemp.GetLength(0) && diaSemana < RegistroTemp.GetLength(1))
            {
                RegistroTemp[semana, diaSemana] = reg;
            }
            else
            {
               Console.WriteLine("La fecha proporcionada está fuera del rango de la matriz.");
            }
        }



        public void VerTemperaturas()
        {
            int cont = 0;
            for (int i = 0; i < RegistroTemp.GetLength(0); i++)
            {
                for (int j = 0; j < RegistroTemp.GetLength(1); j++)
                {
                    cont++;
                    if (cont < 31)
                    {
                        if (RegistroTemp[i, j] == null)
                        {
                            Console.Write("0\t");
                        }
                        else
                        {
                            if (RegistroTemp[i, j] != null)
                            {
                                Console.Write(RegistroTemp[i, j].TemperaturaRegistrada + "°" + "\t");
                            }
                        }
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Presiona Enter para continuar...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }

        }



    }
}
