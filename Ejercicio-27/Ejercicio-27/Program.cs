using System;

namespace Ejercicio_27
{
    class Program
    {
        static int M, conteo;
        static string entrada;
        static float numero;
        static void Main(string[] args)
        {
            
            M = 1;  
            conteo = 0;  
            entrada = "";
            numero = 0;

            multiploDe2Y3ConteoImpresion();
            Console.ReadKey();
        }

        static private void multiploDe2Y3ConteoImpresion()
        {
            Console.WriteLine("Ingrese un número para determinar el fin del ciclo, para imprimir los múltiplos de 2 y 3 hasta el número que usted ingreso");
            entrada = Console.ReadLine();
            numero = Convert.ToSingle(entrada);

            while (M <= numero)  
            {
                if ((M % 2 == 0) && (M % 3 == 0))  
                {
                    Console.WriteLine(M);  
                    conteo = conteo + 1;  
                }

                M = M + 1; 
            }

            Console.WriteLine("Hay un total de " + conteo + "múltiplos de 2 y tres, desde la unidad hasta " + numero);
        }
    }
}
