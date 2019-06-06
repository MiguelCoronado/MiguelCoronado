using System;

namespace Ejercicio_20
{
    class Program
    {
        static int M, conteo;
        static void Main(string[] args)
        {
            M = 1;  
            conteo = 0;  

            multiploDe2o3ConteoImpresion();
            Console.ReadKey();
        }

        static private void multiploDe2o3ConteoImpresion()
        {
            while (M <= 100)  
            {
                if ((M % 2 == 0) || (M % 3 == 0))  
                {
                    Console.WriteLine(M); 
                    conteo = conteo + 1; 
                }

                M = M + 1;  
            }

            Console.WriteLine("Hay un total de múltiplos de: " + conteo);
        }
    }
}
