using System;

namespace Ejercicio_11
{
    class Program
    {
        static int M, conteo, suma;
        static float numero;
        static string entrada;
        static void Main(string[] args)
        {
            M = 2;  
            conteo = 0;  
            suma = 0;  
            numero = 0;  
            entrada = "";  

            conteoSumaMultiplos2();
            Console.ReadKey();
        }

        static private void conteoSumaMultiplos2()
        {
            Console.WriteLine("Ingrese un número: ");  
            entrada = Console.ReadLine();  

            numero = Convert.ToSingle(entrada);  

            while (M <= numero)  
            {
                Console.WriteLine(M);  
                suma = suma + M;  
                M = M + 2;  
                conteo = conteo + 1;  
            }

            Console.WriteLine("Hay un total de: " + conteo + " múltplos de 2");  
            Console.WriteLine("La suma total de los " + conteo + " múltiplos de es es de: " + suma);
        }
    }
}
