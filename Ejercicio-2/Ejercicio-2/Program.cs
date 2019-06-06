using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = 100;

            while (M >= 0)
            {
                Console.WriteLine(M);
                M = M - 1;
            }
            Console.ReadKey();
        }
    }
}
