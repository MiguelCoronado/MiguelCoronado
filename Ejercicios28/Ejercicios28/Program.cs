using System;

namespace Ejercicios28
{
    class Program
    {
        static int M, conteo;
        static float sumaMultiplos5, numeroDeterminado, numMayor, numero;
        static string entrada;
        static void Main(string[] args)
        {
            
            M = 1;
            sumaMultiplos5 = 0;
            numeroDeterminado = 0;
            numMayor = 0;
            entrada = "";
            numero = 0;
            conteo = 0;

            serieDeNumerosMultDe5();
            Console.ReadKey();

        }

        static private void serieDeNumerosMultDe5()
        {
            Console.WriteLine("Ingrese el número para determinar el fin de la serie de números");  
            entrada = Console.ReadLine(); 
            numeroDeterminado = Convert.ToSingle(entrada);  

            while (M <= numeroDeterminado)  
            {
                Console.WriteLine("Ingrese un número: ");  
                entrada = Console.ReadLine();  
                numero = Convert.ToSingle(entrada);  

                if (numero % 5 == 0)  
                {
                    sumaMultiplos5 = sumaMultiplos5 + numero;  
                }
                if (numero > numMayor)  
                {
                    numMayor = numero;  
                }
                M = M + 1;  
                conteo = conteo + 1;  

            }

            
            Console.WriteLine("La suma de los múltiplos de 5 es de: " + sumaMultiplos5);
            Console.WriteLine("El número mayor es: " + numMayor);
            Console.WriteLine("Usted ingresó un total de: " + conteo + " números");
        }
    }
}
