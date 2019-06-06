using System;

namespace Ejercicio_6
{
    class Program
    {
        static int M, suma;
        static void Main(string[] args)
        {
            M = 99;
            suma = 0;  

            imparesDe100a1andSuma();
            Console.ReadKey();
        }

        static private void imparesDe100a1andSuma()
        {
            while (M >= 1) 
            {
                Console.WriteLine(M); 
                suma = suma + M;  
                M = M - 2;  
            }

            Console.WriteLine("La suma total de los números impares de 100 es de: " + suma);

        }
    }
}
