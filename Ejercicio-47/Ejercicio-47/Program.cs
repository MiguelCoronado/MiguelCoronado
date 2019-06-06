using System;

namespace Ejercicio_47
{
    class Program
    {
        static int M, sumaImpar;
        static void Main(string[] args)
        {
            
            M = 1;
            sumaImpar = 0;

            sumaImparDel1Al1000();
            Console.ReadKey();
        }

        static private void sumaImparDel1Al1000()
        {
            
            while (M <= 1000)
            {
                Console.WriteLine(M);  

                
                if (M % 2 == 1)  
                {
                    sumaImpar = sumaImpar + M;  
                }

                M = M + 1;  
            }

            
            Console.WriteLine("La suma total de los números impares del 1 al 100 es de: " + sumaImpar);
        }
    }
}
