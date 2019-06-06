using System;

namespace Ejercico_10
{
    class Program
    {
        static int M, conteo;
        static void Main(string[] args)
        {
            M = 5;  
            conteo = 0;  

            multiplosDe5();
            Console.ReadKey();
        }

        static private void multiplosDe5()
        {
            while (M <= 500)  
            {
                Console.WriteLine(M);  
                M = M + 5;  
                conteo = conteo + 1;  
            }

            Console.WriteLine("Hay un total de: " + conteo + " múltiplos de 5 de 0 a 500");

        }
    }
}
