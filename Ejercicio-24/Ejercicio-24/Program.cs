using System;

namespace Ejercicio_24
{
    class Program
    {
        static string entrada;
        static int numero, M;
        static void Main(string[] args)
        {
            entrada = "";  
            numero = 0;  
            M = 0; 

            ingresoDeNumeros1al100();
            Console.ReadKey();
        }

        static private void ingresoDeNumeros1al100()
        {
            Console.WriteLine("Ingrese un número: ");  
            entrada = Console.ReadLine();  
            numero = Convert.ToInt32(entrada);  

            M = numero;  

            if (M % 2 == 1)  
            {
                while (M <= 100)  
                {
                    if (M % 2 == 1)  
                    {
                        Console.WriteLine(M);  
                        M = M + 1;  
                    }
                    else
                    {
                        M = M + 1;  
                    }
                }
            }
            else
            {
                Console.WriteLine("Error, Usted ingresó un múltiplo de 2");
            }
        }
    }
}
