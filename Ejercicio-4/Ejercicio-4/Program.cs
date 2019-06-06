using System;

namespace Ejercicio_4
{
    class Program
    {
        static int M;
        static void Main(string[] args)
        {
            M = 0;

            numerosPares0al100();
            Console.ReadKey();
        }

        static private void numerosPares0al100()
        {
            while (M <= 100)
            {
                Console.WriteLine(M); 
                M = M + 2;
            }
        }
    }
}
                