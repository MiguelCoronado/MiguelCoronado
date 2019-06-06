using System;

namespace Ejercicio_17
{
    class Program
    {
        static float numero;
        static string entrada;
        static void Main(string[] args)
        {
            numero = 0;  
            entrada = "";  

            numeroPositivoNegativo();
            Console.ReadKey();
        }

        static private void numeroPositivoNegativo()
        {
            Console.WriteLine("Ingrese un número para saber si es par o impar: ");  
            entrada = Console.ReadLine();  
            numero = Convert.ToSingle(entrada);  

            if (numero % 2 == 0)  
            {
                Console.WriteLine("El número que ingreso es par: ");  
            }
            else
            {
                Console.WriteLine("El número que ingreso es impar: ");
            }
         }
    }
}
