using System;

namespace Ejercicio_7
{
    class Program
    {
        static int M;
        static float numero;
        static string entrada;
        static void Main(string[] args)
        {
            M = 1;  
            entrada = "";  
            numero = 0;  

            numerosNaturalesDesde1An();
            Console.ReadKey();
        }

        static private void numerosNaturalesDesde1An()
        {
            Console.WriteLine("Ingrese un número"); 
            entrada = Console.ReadLine(); 
            numero = Convert.ToSingle(entrada);  

            while (M <= numero)  
            {
                Console.WriteLine(M);  
                M = M + 1;
                 }
            }
    }
}
