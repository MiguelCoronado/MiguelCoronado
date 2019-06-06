using System;

namespace Ejercicio_33
{
    class Program
    {
        static float numero, factor;
        static int M;
        static string entrada;
        static void Main(string[] args)
        {
            
            M = 1;
            numero = 0;
            entrada = "";
            factor = 1;

            bucleParaFactorial();
            Console.ReadKey();
        }

        static private void bucleParaFactorial()
        {
            Console.WriteLine("Ingrese un número para obtener su factorial: ");  
            entrada = Console.ReadLine(); 
            numero = Convert.ToSingle(entrada); 

            
            while (M <= numero)  
            {
                factor = factor * M;  
                M = M + 1;  
            }

           
            if (numero >= 0)  
            {
                Console.WriteLine("La factorial del número es de: " + factor); 
            }
            else
            {
                Console.WriteLine("Los números negativos no tienne factorial");
            }
        }
    }
}
