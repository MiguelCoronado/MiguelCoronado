using System;

namespace Ejercicio_14
{
    class Program
    {
        static int M, suma, potencia;
        static double numeros;
        static void Main(string[] args)
        {
            M = 0;  

            numerosParesdel0al100Cuadrados();
            Console.ReadKey();
        }

        static private void numerosParesdel0al100Cuadrados()
        {
            while (M <= 100)  
            {
                numeros = Math.Pow(M, 2);  
                potencia = Convert.ToInt32(numeros);  
                suma = suma + potencia;  
                M = M + 2;  
            }

            Console.WriteLine("La suma de los cuadrados pares del 0 y 100 es de: " + suma);
        }
    }
}
