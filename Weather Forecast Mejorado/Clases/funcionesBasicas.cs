using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Weather_Forecast_Mejorado
{
    internal static class FuncionesBasicas
    {
        public static EstacionMeteorologica CargaPersonasAutomaticasYTemp()
        {
            EstacionMeteorologica est = new EstacionMeteorologica();

            Pasante pas = new Pasante();
            pas.Nombre = "Lucas";
            pas.Apellido = "Cassaretto";
            pas.Dni = 42087420;
            pas.Legajo = 7689;

            Profesional pro = new Profesional();
            pro.Nombre = "ingrid";
            pro.Apellido = "Espinosa";
            pro.Dni = 42345887;
            pro.Matricula = 1234;

            Pasante pas1 = new Pasante();
            pas1.Nombre = "Lucas";
            pas1.Apellido = "Cassaretto";
            pas1.Dni = 42087420;
            pas1.Legajo = 7689;

            Profesional pro1 = new Profesional();
            pro1.Nombre = "ingrid";
            pro1.Apellido = "Espinosa";
            pro1.Dni = 42345887;
            pro1.Matricula = 1234;

            Pasante pas2 = new Pasante();
            pas2.Nombre = "Lucas";
            pas2.Apellido = "Cassaretto";
            pas2.Dni = 42087420;
            pas2.Legajo = 7689;

            Profesional pro2 = new Profesional();
            pro2.Nombre = "ingrid";
            pro2.Apellido = "Espinosa";
            pro2.Dni = 42345887;
            pro2.Matricula = 1234;


            DateOnly[] fechas = new DateOnly[]
            {
                    new DateOnly(2024, 3, 1),
                    new DateOnly(2024, 3, 2),
                    new DateOnly(2024, 3, 3),
                    new DateOnly(2024, 3, 4),
                    new DateOnly(2024, 3, 5),
                    new DateOnly(2024, 3, 6),
                    new DateOnly(2024, 3, 7),
                    new DateOnly(2024, 3, 8),
                    new DateOnly(2024, 3, 9),
                    new DateOnly(2024, 3, 10),
                    new DateOnly(2024, 3, 11),
                    new DateOnly(2024, 3, 12),
                    new DateOnly(2024, 3, 13),
                    new DateOnly(2024, 3, 14),
                    new DateOnly(2024, 3, 15),
                    new DateOnly(2024, 3, 16),
                    new DateOnly(2024, 3, 17),
                    new DateOnly(2024, 3, 18),
                    new DateOnly(2024, 3, 19),
                    new DateOnly(2024, 3, 20),
                    new DateOnly(2024, 3, 21),
                    new DateOnly(2024, 3, 22),
                    new DateOnly(2024, 3, 23),
                    new DateOnly(2024, 3, 24),
                    new DateOnly(2024, 3, 25),
                    new DateOnly(2024, 3, 26),
                    new DateOnly(2024, 3, 27),
                    new DateOnly(2024, 3, 28),
                    new DateOnly(2024, 3, 29),
                    new DateOnly(2024, 3, 30),
                    new DateOnly(2024, 3, 31)

            };
            TimeOnly horaRegistro = new TimeOnly(14, 30);

            RegistroTemperatura reg = new RegistroTemperatura(3.5, fechas[0], horaRegistro, pas, null);
            RegistroTemperatura reg1 = new RegistroTemperatura(13.1, fechas[1], horaRegistro, null, pro);
            RegistroTemperatura reg2 = new RegistroTemperatura(22.4, fechas[2], horaRegistro, pas1, null);
            RegistroTemperatura reg3 = new RegistroTemperatura(33.8, fechas[3], horaRegistro, null, pro1);
            RegistroTemperatura reg4 = new RegistroTemperatura(7.6, fechas[4], horaRegistro, pas2, null);
            RegistroTemperatura reg5 = new RegistroTemperatura(32.0, fechas[5], horaRegistro, null, pro2);
            RegistroTemperatura reg6 = new RegistroTemperatura(2.9, fechas[6], horaRegistro, pas, null);
            RegistroTemperatura reg7 = new RegistroTemperatura(14.2, fechas[7], horaRegistro, null, pro);
            RegistroTemperatura reg8 = new RegistroTemperatura(26.7, fechas[8], horaRegistro, pas1, null);
            RegistroTemperatura reg9 = new RegistroTemperatura(31.1, fechas[9], horaRegistro, null, pro1);
            RegistroTemperatura reg10 = new RegistroTemperatura(29.3, fechas[10], horaRegistro, pas2, null);
            RegistroTemperatura reg11 = new RegistroTemperatura(24.5, fechas[11], horaRegistro, null, pro2);
            RegistroTemperatura reg12 = new RegistroTemperatura(7.8, fechas[12], horaRegistro, pas, null);
            RegistroTemperatura reg13 = new RegistroTemperatura(11.0, fechas[13], horaRegistro, null, pro);
            RegistroTemperatura reg14 = new RegistroTemperatura(29.9, fechas[14], horaRegistro, pas1, null);
            RegistroTemperatura reg15 = new RegistroTemperatura(32.7, fechas[15], horaRegistro, null, pro1);
            RegistroTemperatura reg16 = new RegistroTemperatura(28.4, fechas[16], horaRegistro, pas2, null);
            RegistroTemperatura reg17 = new RegistroTemperatura(31.6, fechas[17], horaRegistro, null, pro2);
            RegistroTemperatura reg18 = new RegistroTemperatura(9.1, fechas[18], horaRegistro, pas, null);
            RegistroTemperatura reg19 = new RegistroTemperatura(3.3, fechas[19], horaRegistro, null, pro);
            RegistroTemperatura reg20 = new RegistroTemperatura(6.5, fechas[20], horaRegistro, pas1, null);
            RegistroTemperatura reg21 = new RegistroTemperatura(31.9, fechas[21], horaRegistro, null, pro1);
            RegistroTemperatura reg22 = new RegistroTemperatura(28.7, fechas[22], horaRegistro, pas2, null);
            RegistroTemperatura reg23 = new RegistroTemperatura(34.4, fechas[23], horaRegistro, null, pro2);
            RegistroTemperatura reg24 = new RegistroTemperatura(30.2, fechas[24], horaRegistro, pas, null);
            RegistroTemperatura reg25 = new RegistroTemperatura(3.3, fechas[25], horaRegistro, null, pro);
            RegistroTemperatura reg26 = new RegistroTemperatura(6.5, fechas[26], horaRegistro, pas1, null);
            RegistroTemperatura reg27 = new RegistroTemperatura(31.9, fechas[27], horaRegistro, null, pro1);
            RegistroTemperatura reg28 = new RegistroTemperatura(28.7, fechas[28], horaRegistro, pas2, null);
            RegistroTemperatura reg29 = new RegistroTemperatura(34.4, fechas[29], horaRegistro, null, pro2);
            RegistroTemperatura reg30 = new RegistroTemperatura(30.2, fechas[30], horaRegistro, pas, null);



            est.RegistrarTemperatura(reg);
            est.RegistrarTemperatura(reg1);
            est.RegistrarTemperatura(reg2);
            est.RegistrarTemperatura(reg3);
            est.RegistrarTemperatura(reg4);
            est.RegistrarTemperatura(reg5);
            est.RegistrarTemperatura(reg6);
            est.RegistrarTemperatura(reg7);
            est.RegistrarTemperatura(reg8);
            est.RegistrarTemperatura(reg9);
            est.RegistrarTemperatura(reg10);
            est.RegistrarTemperatura(reg11);
            est.RegistrarTemperatura(reg12);
            est.RegistrarTemperatura(reg13);
            est.RegistrarTemperatura(reg14);
            est.RegistrarTemperatura(reg15);
            est.RegistrarTemperatura(reg16);
            est.RegistrarTemperatura(reg17);
            est.RegistrarTemperatura(reg18);
            est.RegistrarTemperatura(reg19);
            est.RegistrarTemperatura(reg20);
            est.RegistrarTemperatura(reg21);
            est.RegistrarTemperatura(reg22);
            est.RegistrarTemperatura(reg23);
            est.RegistrarTemperatura(reg24);
            est.RegistrarTemperatura(reg25);
            est.RegistrarTemperatura(reg26);
            est.RegistrarTemperatura(reg27);
            est.RegistrarTemperatura(reg28);
            est.RegistrarTemperatura(reg29);
            est.RegistrarTemperatura(reg30);
      

            return est;

        }

        public static void Menu()
        {
            bool continua = true;
            //se realiza la carga de datos de forma automatica
            EstacionMeteorologica est = FuncionesBasicas.CargaPersonasAutomaticasYTemp();

            do
            {
              
                Console.WriteLine("------------------------------------------------------------");                                                                                                                                                                                                     
                Console.WriteLine("1. Ver temperatura de dia especifico");
                Console.WriteLine("2. Calcular y ver temperaturas promedios de cada semana");
                Console.WriteLine("3. Encontrar y ver temperaturas por encima de 20° (Umbral)");
                Console.WriteLine("4. Ver la temperatura promedio del mes");
                Console.WriteLine("5. Ver la temperatura más alta");
                Console.WriteLine("6. Ver la temperatura más baja");
                Console.WriteLine("7. Ver calendario de temperaturas ");
                Console.WriteLine("0. Salir del programa ");
                Console.Write("Ingrese su opcion deseada --> ");
                if (int.TryParse(Console.ReadLine(), out int opc) == false)
                {
                    Console.WriteLine("!DEBE INGRESAR UNA OPCION VALIDA¡");
                    continue;
                }
                Console.WriteLine();
                switch (opc)
                {

                    case 1:
                        CalculoTemperaturas.TemperaturaDiaEspecifico(est);
                
                        break;

                    case 2:
                        CalculoTemperaturas.PromedioSemanal(est);
                       
                        break;

                    case 3:
                        CalculoTemperaturas.TemperaturasMayoresA20(est);
                
                        break;

                    case 4:
                        CalculoTemperaturas.PromedioMes(est);
                       
                        break;

                    case 5:
                       CalculoTemperaturas.TemperaturaAlta(est);
                     
                        break;
                    case 6:
                        CalculoTemperaturas.TemperaturaMasBaja(est);

             
                        break;
                    case 7:

                        est.VerTemperaturas();

                     
                        break;
                   
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        return;

                    default:
                        Console.WriteLine("¡DEBE INGRESAR UNA OPCION VÁLIDA!");
                        break;
                }
            

                if (opc != 7) Console.Clear(); //Validación para que la consola no se limpie cuando vemos el calendario, para asi poder comprobar nuetras respuestas

            } while (continua);
        }


    }
}
