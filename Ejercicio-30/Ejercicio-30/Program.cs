using System;

namespace Ejercicio_30
{
    class Program
    {
        static float cantidad, porcentaje50, porcentaje7, restaPorcentaje5, sumaPorcentaje50, sumaPorcentaje7, porcentaje5;
        static string entrada;
        static void Main(string[] args)
        {
            
            cantidad = 0;
            porcentaje50 = 0;
            sumaPorcentaje50 = 0;
            porcentaje7 = 0;
            restaPorcentaje5 = 0;
            porcentaje7 = 0;
            porcentaje5 = 0;
            sumaPorcentaje7 = 0;
            entrada = "";

            porcentajes();
            Console.ReadKey();
        }

        static private void porcentajes()
        {
            Console.WriteLine("Ingrese una cantidad: ");  
            entrada = Console.ReadLine();  
            cantidad = Convert.ToSingle(entrada);  

            
            if (cantidad < 500)  
            {
                porcentaje50 = cantidad * 0.5f;  
                sumaPorcentaje50 = cantidad + porcentaje50;  
                Console.WriteLine("La suma del 50 porciento es de: " + sumaPorcentaje50);  
            }
            else
            {
                Console.WriteLine(cantidad + " no es menor que 500");  
            }

            
            if ((cantidad >= 500) && (cantidad < 1000)) 
            {
                porcentaje7 = cantidad * 0.07f;  
                sumaPorcentaje7 = cantidad + porcentaje7;  
                Console.WriteLine("La suma del 7 porciento es de: " + sumaPorcentaje7);  
            }
            else
            {
                Console.WriteLine("Su cantidad no es mayor o igual que 500, o no sea menor que 1000 ");  
            }

            
            if ((cantidad > 1000) && (cantidad <= 5000))  
            {
                porcentaje5 = cantidad * 0.05f;  
                restaPorcentaje5 = cantidad - porcentaje5;  
                Console.WriteLine("La resta del 5 porciento es de: " + restaPorcentaje5);  
            }
            else
            {
                Console.WriteLine("Su cantidad ni es mayor que 1000, o no sea menor o igual que 5000");
            }
        }
    }
}
