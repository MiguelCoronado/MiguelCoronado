using System;

namespace Ejercicio_16
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
            Console.WriteLine("Ingrese un número para saber si es positivo o negativo: ");  
            entrada = Console.ReadLine();  
            numero = Convert.ToSingle(entrada);  

            if (numero > 0)  
            {
                Console.WriteLine("El número que ingreso es positivo: ");  
            }
            else
            {
                Console.WriteLine("El número que ingreso es negativo: ");
            }
        }
    }
}
