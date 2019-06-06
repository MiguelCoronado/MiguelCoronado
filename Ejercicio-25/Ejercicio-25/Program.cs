using System;

namespace Ejercicio_25
{
    class Program
    {
        static float numero;
        static int M;
        static string entrada;
        static void Main(string[] args)
        {
            numero = 0;  
            entrada = "";  
            M = 1;  

            serieDeNumerosMayorMenor();
            Console.ReadKey();
        }

        static private void serieDeNumerosMayorMenor()
        {
            while (M <= 5)  
            {
                Console.WriteLine("Ingrese un número: ");  
                entrada = Console.ReadLine();  
                numero = Convert.ToSingle(entrada); 

                if (numero > 10)  
                {
                    Console.WriteLine(numero + " es mayor que 10");  
                }
                else
                {
                    Console.WriteLine(numero + " es menor que 10");  
                }

                M = M + 1;  
            }
        }
    }
    }
   




