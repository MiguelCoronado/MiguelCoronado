using System;

namespace Ejercicio_50
{
    class Program
    {
        static int M, cuadrado, cubo;
        static double potencia;
        static void Main(string[] args)
        {
            
            M = 1;
            cuadrado = 0;
            cubo = 0;

            
            cuadradosCubosDel1al10();

            Console.ReadKey();
        }

        static private void cuadradosCubosDel1al10()
        {
            
            while (M <= 10)
            {
                potencia = Math.Pow(M, 2);  
                cuadrado = Convert.ToInt32(potencia);  

                potencia = Math.Pow(M, 3);  
                cubo = Convert.ToInt32(potencia);  

                Console.WriteLine(M + " ; " + cuadrado + " ; " + cubo);  
                M = M + 1;
            }
       }
    }
}
