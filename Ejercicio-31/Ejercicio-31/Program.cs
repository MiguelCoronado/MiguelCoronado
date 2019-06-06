using System;

namespace Ejercicio_31
{
    class Program
    {
        static int M, serie10;
        static void Main(string[] args)
        {
            
            M = 0;
            serie10 = 0;

            
            while (serie10 <= 10)  
            {
                M = 1;  
                while (M <= 10)  
                {
                    Console.WriteLine(M);  
                    M = M + 1;  
                }
                serie10 = serie10 + 1;  
            }

            Console.ReadKey();
        }
    }
}
