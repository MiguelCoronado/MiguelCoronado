using System;

namespace Ejercicio_21
{
    class Program
    {
        static int M, conteo;
        static void Main(string[] args)
        {
            M = 1;  
            conteo = 0;  

            multiploDe2Y3ConteoImpresion();
            Console.ReadKey();
        }

        static private void multiploDe2Y3ConteoImpresion()
        {
            while (M <= 100)  
            {
                if ((M % 2 == 0) && (M % 3 == 0))  
                {
                    Console.WriteLine(M);  
                    conteo = conteo + 1;  
                }

                M = M + 1;  
            }

            Console.WriteLine("Hay un total de " + conteo + " múltiplos de 2 y de 3, desde uno hasta 100");
        }
    }
}
