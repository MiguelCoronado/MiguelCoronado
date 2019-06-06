using System;

namespace Ejercicio_26
{
    class Program
    {
        static int M, suma, sumaMultiplo;
        static float numero;
        static string entrada;
        static void Main(string[] args)
        {
            
            M = 0;
            numero = 0;
            suma = 0;
            sumaMultiplo = 0;
            entrada = "";

            bucleParaMultiplosDe5Suma();
            Console.ReadKey();
        }

        static private void bucleParaMultiplosDe5Suma()
        {
            Console.WriteLine("Ingrese un número para determinar el fin del ciclo: ");  
            entrada = Console.ReadLine();  
            numero = Convert.ToSingle(entrada);  

            while (M <= numero)  
            {
                if (M % 5 == 0)  
                {
                    sumaMultiplo = sumaMultiplo + M;  
                    M = M + 1;  
                }
                else
                {
                    Console.WriteLine(M);  
                    suma = suma + M;  
                    M = M + 1;  
                }
            }

            Console.WriteLine("La suma total de los numeros, menos los múltiplos de 5, desde cero a" + numero + " es de: " + suma);  
            Console.WriteLine("La suma de los múltiplos de 5 desde cero a " + numero + " es de: " + sumaMultiplo);
        }
    }
}
