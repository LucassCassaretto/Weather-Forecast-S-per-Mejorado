using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Weather_Forecast_Mejorado
{
    internal static class CalculoTemperaturas
    {


        public static void TemperaturaDiaEspecifico(EstacionMeteorologica RegistroTemp)
        {
            int cont = 0;
            int Dia = 0;
            double tempe = 0;
            do
            {
                Console.Write("Ingrese dia, para ver su temperatura: ");
                int.TryParse(Console.ReadLine(), out Dia);
                if (Dia > 1 && Dia <= 31) break;

                Console.WriteLine("Debe ingresar un dia valido!");

            } while (true);
            for (int i = 0; i < RegistroTemp.RegistroTemp.GetLength(0); i++)
            {
                for (int j = 0; j < RegistroTemp.RegistroTemp.GetLength(1); j++)
                {
                    cont++;
                    if (cont == Dia)
                    {
                        if (RegistroTemp.RegistroTemp[i, j] == null)
                        {
                            Console.WriteLine("No hay temperatura registrada para ese dia");
                            Console.Write("Ingrese dia, para ver su temperatura: ");
                            int.TryParse(Console.ReadLine(), out Dia);
                            continue;
                        }
                        else
                        {
                            tempe = RegistroTemp.RegistroTemp[i, j].TemperaturaRegistrada;
                            Console.WriteLine("La temperatura del dia indicado es: " + tempe + "° Grados");
                            if (RegistroTemp.RegistroTemp[i, j].Pasante != null)
                            {
                                Console.WriteLine($"Temperatura registrada por: {RegistroTemp.RegistroTemp[i, j].Pasante.Nombre} Legajo: {RegistroTemp.RegistroTemp[i, j].Pasante.Legajo}");
                            }else if (RegistroTemp.RegistroTemp[i, j].Profesional != null)
                            {
                                Console.WriteLine($"Temperatura registrada por: {RegistroTemp.RegistroTemp[i, j].Profesional.Nombre} Matricula: {RegistroTemp.RegistroTemp[i, j].Profesional.Matricula}");
                            }
                            Console.WriteLine($"Fecha de registro: { RegistroTemp.RegistroTemp[i, j].FechaRegistro}");
                            Console.WriteLine($"Hora de registro: {RegistroTemp.RegistroTemp[i, j].HoraRegistro}");

                        }
                    }
                }
            }


            if (tempe < 0) Console.WriteLine("Hizo mucho frío.");
            else if (tempe <= 20) Console.WriteLine("El clima estaba fresco.");
            else Console.WriteLine("Hizo calor afuera.");

            Console.WriteLine();
            Console.WriteLine("Presiona Enter para continuar...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
            Console.WriteLine("------------------------------------------");

        }

        public static void PromedioSemanal(EstacionMeteorologica RegistroTemp)
        {
            int cont = 0;
            double[] promedio = new double[5];
            double suma;
            int dias= 0;
            for (int i = 0; i < RegistroTemp.RegistroTemp.GetLength(0); i++)
            {
                suma = 0;
                dias = 0;
                for (int j = 0; j < RegistroTemp.RegistroTemp.GetLength(1); j++)
                {
                    cont++;

                    if (cont <= 31)
                    {
                        if (RegistroTemp.RegistroTemp[i, j] != null)
                        {
                            suma += RegistroTemp.RegistroTemp[i, j].TemperaturaRegistrada;
                            dias++;
                        }
                    }

                }
                promedio[i] = suma;
                double division = promedio[i] / dias;
                promedio[i] = division;


            }

            for (int p = 0; p < 5; p++)
            { 
                Console.WriteLine("El promedio de temperatura de la semana " + (p + 1) + " es de " + $"{promedio[p]:F1}" + "° Grados");
            }
            Console.WriteLine();
            Console.WriteLine("Presiona Enter para continuar...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
            Console.WriteLine("------------------------------------------");

        }

        public static void TemperaturasMayoresA20(EstacionMeteorologica RegistroTemp)
        {
            double[] temperaturaMayorA20 = new double[31];
            int cont = 0;

            for (int i = 0; i < RegistroTemp.RegistroTemp.GetLength(0); i++)
            {
                for (int j = 0; j < RegistroTemp.RegistroTemp.GetLength(1); j++)
                {
                    if (RegistroTemp.RegistroTemp[i, j] != null)
                    {
                        if (RegistroTemp.RegistroTemp[i, j].TemperaturaRegistrada > 20)
                        {
                            temperaturaMayorA20[cont] = RegistroTemp.RegistroTemp[i, j].TemperaturaRegistrada;
                            cont++;
                        }
                    }
                }

            }

            Console.WriteLine("Las temperaturas mayores a 20° son : ");

            foreach (double t in temperaturaMayorA20)
            {
                if (t != 0) Console.WriteLine(t + "° grados");

            }
            Console.WriteLine();
            Console.WriteLine("Presiona Enter para continuar...");

            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }

        public static void PromedioMes(EstacionMeteorologica RegistroTemp)
        {
            int cont = 0;
            double suma = 0;
            int dia = 0;
            for (int i = 0; i < RegistroTemp.RegistroTemp.GetLength(0); i++)
            {
                for (int j = 0; j < RegistroTemp.RegistroTemp.GetLength(1); j++)
                {
                    cont++;
                    if (cont <= 31)
                    {
                        if (RegistroTemp.RegistroTemp[i, j] != null)
                        {
                            suma += RegistroTemp.RegistroTemp[i, j].TemperaturaRegistrada;
                            dia++;
                        }
                    }
                }
            }
            double promedio = suma / dia;

            Console.WriteLine($"El promedio del mes en temperatura es de: { promedio:F1}");

            Console.WriteLine();
            Console.WriteLine("Presiona Enter para continuar...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
            Console.WriteLine("------------------------------------------");
        }

        public static void TemperaturaAlta(EstacionMeteorologica RegistroTemp)
        {
            double max = 0;
            int cont = 0;
            for (int i = 0; i < RegistroTemp.RegistroTemp.GetLength(0); i++)
            {
                for (int j = 0; j < RegistroTemp.RegistroTemp.GetLength(1); j++)
                {
                    cont++;
                    
                    if (cont <= 31)
                    {
                        if(RegistroTemp.RegistroTemp[i, j] != null)
                        {
                            if (cont == 1) max = RegistroTemp.RegistroTemp[i, j].TemperaturaRegistrada;
                            else if (RegistroTemp.RegistroTemp[i, j].TemperaturaRegistrada > max) max = RegistroTemp.RegistroTemp[i, j].TemperaturaRegistrada;
                        }
                    }
                }

            }

            Console.WriteLine($"la temperatura mas alta es {max}° grados");
            Console.WriteLine();
            Console.WriteLine("Presiona Enter para continuar...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
            Console.WriteLine("------------------------------------------");
        }

        public static void TemperaturaMasBaja(EstacionMeteorologica RegistroTemp)
        {

            double min = double.MaxValue;
            int cont = 0;

            for (int i = 0; i < RegistroTemp.RegistroTemp.GetLength(0); i++)
            {
                for (int j = 0; j < RegistroTemp.RegistroTemp.GetLength(1); j++)
                {
                    cont++;
                    if (cont <= 31)
                    {

                        if (RegistroTemp.RegistroTemp[i, j] != null)
                        {
                            double tempActual = RegistroTemp.RegistroTemp[i, j].TemperaturaRegistrada;
                            if (tempActual < min && tempActual != 0)
                            {
                                min = tempActual;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"La temperatura mas baja es {min}° grados");
            Console.WriteLine();
            Console.WriteLine("Presiona Enter para continuar...");
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
            Console.WriteLine("------------------------------------------");

        }


    }
}
