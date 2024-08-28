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
        public RegistroTemperatura? RegistroTemperatura { get; set; }
        public RegistroTemperatura[,] Matriz {  get; set; } = new RegistroTemperatura[5, 7];



        public EstacionMeteorologica()
        {
            Matriz = new RegistroTemperatura[5, 7];
        }


        public void RegistrarTemperatura(RegistroTemperatura registroTemperatura)
        {
            int dia = registroTemperatura.FechaRegistro.Day;
            int cont = 0;

            for(int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int u = 0; u < Matriz.GetLength(1); u++)
                {cont++;

                    if (cont == dia)
                    {
                        Matriz[i,u]= registroTemperatura;
                        
                    }
                }
            }
        }


        public void mostrar()
        { 
            Console.WriteLine("Calendario:");
            int cont = 0;

            for (int i = 0; i < Matriz.GetLength(0); i++)
            {
                for (int j = 0; j < Matriz.GetLength(1); j++)
                {
                    cont++;
                    if (cont <= 31)
                    {
                        if (Matriz[i, j] != null)
                        {

                            Console.Write($"  {Matriz[i, j].TemperaturaRegistrada}  ");
                        }
                        else Console.Write("  ---  ");
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
