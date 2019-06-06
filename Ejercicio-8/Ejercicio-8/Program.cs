using System;

namespace Ejercicio_8
{
    class Program
    {
        static int M, conteo;
        static void Main(string[] args)
        {
            M = 3;  
            conteo = 0;  

            multiplosDe3De1a100();
            Console.ReadKey();
        }

        static private void multiplosDe3De1a100()
        {
            while (M <= 100)  
            {
                Console.WriteLine(M);  
                M = M + 3;  
                conteo = conteo + 1;  
            }

            Console.WriteLine("Hay un total de: " + conteo + " múltiplos de 3");

        }
    }
}
