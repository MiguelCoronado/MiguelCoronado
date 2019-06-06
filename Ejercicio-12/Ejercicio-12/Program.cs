using System;

namespace Ejercicio_12
{
    class Program
    {
        static int M, conteo, suma;
        static float numero;
        static string entrada;
        static void Main(string[] args)
        {
            M = 10;  
            conteo = 0;  
            suma = 0;  
            numero = 0;  
            entrada = "";  

            conteoSumaMultiplos10();
            Console.ReadKey();
        }

        static private void conteoSumaMultiplos10()
        {
            Console.WriteLine("Ingrese un número: "); 
            entrada = Console.ReadLine();  

            numero = Convert.ToSingle(entrada);  

            while (M <= numero)  
            {
                Console.WriteLine(M);  
                suma = suma + M;  
                M = M + 10;  
                conteo = conteo + 1;  
            }

            Console.WriteLine("Hay un total de: " + conteo + " múltplos de 10");  
            Console.WriteLine("El total de la suma de los " + conteo + " múltiplos de es es de: " + suma);

        }
}
}
