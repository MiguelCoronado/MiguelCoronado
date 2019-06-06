using System;

namespace Ejercicio_19
{
    class Program
    {
        static int M, sumaPar, sumaImpar;
        static void Main(string[] args)
        {
            M = 1;  
            sumaPar = 0;  
            sumaImpar = 0;  

            numerosDel1al100ParImpar();
            Console.ReadKey();
        }

        static private void numerosDel1al100ParImpar()
        {
            while (M <= 100)  
            {
                Console.WriteLine(M);  

                if (M % 2 == 0)  
                {
                    sumaPar = sumaPar + M;  
                }
                else
                {
                    sumaImpar = sumaImpar + M;  

                }
                M = M + 1;  
            }

            Console.WriteLine("La suma de los números pares de 1 a 100 es de: " + sumaPar); 
            Console.WriteLine("La suma de los números impares de 1 a 100 es de: " + sumaImpar);
        }
    }
}
