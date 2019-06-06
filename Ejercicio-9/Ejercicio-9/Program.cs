using System;

namespace Ejercicio_9
{
    class Program
    {
        static int M, suma;
        static void Main(string[] args)
        {
            M = 1;  

            suma = 0; 

            sumaDeImparesDe0a100();
        }

        static private void sumaDeImparesDe0a100()
        {
            while (M <= 100)  
            {
                suma = suma + M;  
                M = M + 2;  
            }

            Console.WriteLine("La suma de los impares entre 0 y 100 es de: " + suma);
        }
    }
}

