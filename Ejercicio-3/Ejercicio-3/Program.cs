using System;

namespace Ejercicio_3
{
    class Program
    {
        static int M, suma;
        static void Main(string[] args)
        {
      
                M = 1; 
                suma = 0;

                sumasDeNumeros();
                Console.ReadKey();
            }

            static private void sumasDeNumeros()
            {
                while (M <= 100)
                {
                    suma = suma + M; 
                    M = M + 1;
                    Console.WriteLine(suma);
                }
             }
             }
             }
