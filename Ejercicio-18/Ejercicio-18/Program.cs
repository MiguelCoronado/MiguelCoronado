using System;

namespace Ejercicio_18
{
    class Program
    {
        static float numero;
        static int conteo, M;
        static string entrada;
        static void Main(string[] args)
        {
            M = 3;  
            conteo = 0;  
            entrada = "";  
            numero = 0;  

            multDeTresDesdeUno();
            Console.ReadKey();
        }

        static private void multDeTresDesdeUno()
        {
            Console.WriteLine("Ingrese un número para reconocer los múlitplos de tres desde la unidad hasta el numero que ingreso : ");  //Solicita al usuario ingresar dato.
            entrada = Console.ReadLine();  
            numero = Convert.ToSingle(entrada);  

            while (M <= numero)  
            {
                Console.WriteLine(M);  
                M = M + 3;  
                conteo = conteo + 1;  
            }

            Console.WriteLine("Hay un  total de: " + conteo + " múltiplos de 2, desde la unidad hasta " + numero);
        }
    }
}
