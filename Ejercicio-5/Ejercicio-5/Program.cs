using System;

namespace Ejercicio_5
{
    class Program
    {
        static int M, conteo;
        static void Main(string[] args)
        {
            M = 1; 
            conteo = 0; 

            numerosImparesHasta100YConteo();
            Console.ReadKey();
        }

        static private void numerosImparesHasta100YConteo()
        {
            while (M <= 100)
            {
                Console.WriteLine(M); 
                M = M + 2;  
                conteo = conteo + 1; 
            }

            Console.WriteLine("Existe un total de: " + conteo + " números impares");
        }
    }
}
