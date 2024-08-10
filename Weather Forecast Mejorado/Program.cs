
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

int[,] temperatura = new int[5, 7];


bool continua = true;


do
{
    int cont = 0;
    Console.WriteLine("------------------------------------------------------------");
    Console.WriteLine("1. Ingresar temperaturas mensuales de manera manual ");
    Console.WriteLine("2. Generar temperatura mensual de manera automatica ");
    Console.WriteLine("3. Ver temperatura de dia especifico");
    Console.WriteLine("4. Calcular y ver temperaturas promedios de cada semana");
    Console.WriteLine("5. Encontrar y ver temperaturas por encima de 20° (Umbral)");
    Console.WriteLine("6. Ver la temperatura promedio del mes");
    Console.WriteLine("7. Ver la temperatura más alta");
    Console.WriteLine("8. Ver la temperatura más baja");
    Console.WriteLine("9. Ver el pronóstico de 5 días posteriores al mes.");
    Console.WriteLine("10. Ver calendario de temperaturas ");
    Console.WriteLine("11. Salir del programa ");
    Console.Write("Ingrese su opcion deseada --> ");
    if (int.TryParse(Console.ReadLine(), out int opc) == false)
    {
        Console.WriteLine("!DEBE INGRESAR UNA OPCION VALIDA¡");
        continue;
    }
    Console.WriteLine();
     switch (opc)
        {

            case 1: ingresarTemperaturaManual(temperatura, cont, continua);
                break;

            case 2: temperaturaAutomatica(temperatura, cont, continua);
                break;

            case 3: temperaturaDiaEspecifico(temperatura,cont);                  
                 break;

            case 4: PromedioSemanal(temperatura);
                break;

            case 5: temperaturasMayoresA20(temperatura); 
                break;
            case 6:
                    int promedio = promedioMes(temperatura);
                    Console.WriteLine("La temperatura promedio del mes es de: "+ promedio+ "° grados");
                    Console.WriteLine();
                    Console.WriteLine("Presiona Enter para continuar...");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
                break;
            case 7:
                   int max =  temperaturaAlta(temperatura);
                    Console.WriteLine("La temperatura mas alta durante todo el mes es de: "+max+ "° Grados");
                    
                    Console.WriteLine();
                    Console.WriteLine("Presiona Enter para continuar...");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }

            break;
            case 8:
                    int min = temperaturaBaja(temperatura);
                    Console.WriteLine("La temperatura mas baja durante todo el mes es de: " + min + "° Grados");

                    Console.WriteLine();
                    Console.WriteLine("Presiona Enter para continuar...");
                    while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }


            break;
             case 9: proximos5dias();
                break;

            case 10: mostrarCalendario(temperatura);
                break;

            case 11:
                Console.WriteLine("Saliendo del programa");
                return;

            default:
                Console.WriteLine("¡DEBE INGRESAR UNA OPCION VÁLIDA!");
                break;
    }
} while (continua);








static void ingresarTemperaturaManual(int[,] vec,int cont, bool bol)
{
    for (int i = 0; i < vec.GetLength(0); i++)
    {
        for (int j = 0; j < vec.GetLength(1); j++)
        {
            cont++;
            if (cont <= 31)
            {
                Console.Write("Ingrese temperatura para el dia " + cont + " : ");
                int.TryParse(Console.ReadLine(), out int temp);
                vec[i, j] = temp;
            }
            else break;
        }
    }
    bol = false;
    Console.WriteLine();
    Console.WriteLine("Presiona Enter para continuar...");

    while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
}
static void temperaturaAutomatica(int[,] vec, int cont, bool bol)
{
    Random random = new Random();
    for (int i = 0; i < vec.GetLength(0); i++)
    {
        for (int j = 0; j < vec.GetLength(1); j++)
        {
            cont++;
            if (cont <= 31)
            {
                vec[i, j] = random.Next(-4, 30);
            }
            else break;
        }
    }
    bol = false;
    Console.WriteLine("--Temperaturas generadas con exito!--");
    Console.WriteLine();
    Console.WriteLine("Presiona Enter para continuar...");

    while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
}
static void temperaturaDiaEspecifico(int [,] vec, int cont)
{
    int tempe = 0;
    Console.Write("Ingrese dia, para ver su temperatura: ");
    int.TryParse(Console.ReadLine(), out int Dia);
    if (Dia < 1 && Dia > 31)
    {
        Console.WriteLine("Debe ingresar un dia valido!");
       // break;
    }
    for (int i = 0; i < vec.GetLength(0); i++)
    {
        for (int j = 0; j < vec.GetLength(1); j++)
        {
            cont++;
            if (cont == Dia)
            {
                tempe = vec[i, j];
                Console.WriteLine("La temperatura del dia indicado es: " + tempe);
            }
        }
    }
    if (tempe < 0)        Console.WriteLine("Hizo mucho frío.");
    else if (tempe <= 20) Console.WriteLine("El clima estaba fresco.");
    else Console.WriteLine("Hizo calor afuera.");
   
    Console.WriteLine();
    Console.WriteLine("Presiona Enter para continuar...");
    while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
    Console.WriteLine("------------------------------------------");

}
static void PromedioSemanal(int[,] vec) {
    int cont = 0;
    double[] promedio = new double[5];
    int suma;
    for (int i = 0; i < vec.GetLength(0); i++)
    {
        suma=0;
        for (int j = 0; j < vec.GetLength(1); j++)
        {
            cont++;
            if (cont <= 31)
            {
                suma += vec[i, j];
            }
            
        }
        promedio[i]= suma;
    }

    for(int p=0;p<5;p++)
    {
    
        double division = promedio[p]/ 7;
        promedio[p]= division;

        Console.WriteLine("El promedio de temperatura de la semana " + (p + 1) + " es de " + $"{ promedio[p]:F1}" + "° Grados");
    }
    Console.WriteLine();
    Console.WriteLine("Presiona Enter para continuar...");
    while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
    Console.WriteLine("------------------------------------------");

}
static void temperaturasMayoresA20(int [,] vec)
{
    int[] temperaturaMayorA20 = new int[31];
    int cont = 0;

    for (int i = 0; i < vec.GetLength(0); i++)
    {
        for (int j = 0; j < vec.GetLength(1); j++)
        {
            if (vec[i, j] > 20)
            {
                temperaturaMayorA20[cont] = vec[i, j];
                cont++;
            }
        }

    }

    Console.WriteLine("Las temperaturas mayores a 20° son : ");

    foreach (int t in temperaturaMayorA20)
    {
        if (t!=0) Console.WriteLine(t + "° grados");

    }
    Console.WriteLine();
    Console.WriteLine("Presiona Enter para continuar...");

    while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
}
static int promedioMes(int[,] vec)
{
    int cont = 0;
    int suma = 0;


    for (int i = 0; i < vec.GetLength(0); i++)
    {
        for (int j = 0; j < vec.GetLength(1); j++)
        {
            cont++;
            if (cont <= 31)
            {
                suma += vec[i, j];
            }
        }
    }

    int promedio = suma / 31;

    return promedio;
}
static int temperaturaAlta(int[,] vec)
{ int max=0;
    int cont = 0;
    for (int i = 0; i < vec.GetLength(0); i++)
    {
        for (int j = 0; j < vec.GetLength(1); j++)
        {
            cont++;
            // validación para evitar los ultimos 4 digitos nulos
            if (cont <= 31)
            {
                if (cont == 1) max = vec[i, j];
                else if (vec[i, j] > max) max = vec[i, j];
            } 
        }

    }

    return max ;
}
static int temperaturaBaja(int[,] vec)
{
    int min = 0;
    int cont = 0;
    for (int i = 0; i < vec.GetLength(0); i++)
    {
        for (int j = 0; j < vec.GetLength(1); j++)
        {
            cont++;
            // validación para evitar los ultimos 4 digitos nulos
            if (cont <= 31)
            {
                if (cont == 1) min = vec[i, j];
                else if (vec[i, j] < min) min = vec[i, j];
            }
        }

    }

    return min;
}
static void proximos5dias()
{
    Console.WriteLine("El pronostico para los siguientes 5 dias es: ");
    for (int i = 0; i <= 4; i++)
    {
        Random random = new Random();
        int clima = random.Next(-3, 30);
        int dia = i + 1;
        Console.WriteLine("Dia " + dia + " el clima sera de: " + clima + "° grados centigrados ");
    }

    Console.WriteLine();
    Console.WriteLine("Presiona Enter para continuar...");
    while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
}
static void mostrarCalendario(int [,] vec){
    for (int i = 0; i < vec.GetLength(0); i++)
    {
        for (int j = 0; j < vec.GetLength(1); j++)
        {
            Console.Write(vec[i, j] + "\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine();
    Console.WriteLine("Presiona Enter para continuar...");
    while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }

}