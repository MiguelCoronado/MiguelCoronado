using System;

namespace Ejercicio_40
{
    class Program
    {
        static int numero, contador;
        static string entrada;
        static void Main(string[] args)
        {
            
            numero = 0;
            contador = 0;
            entrada = "";

            numeroPrimo();
            Console.ReadKey();
        }

        static private void numeroPrimo()
        {
            
            Console.WriteLine("Ingrese un número para saber si es primo y para indicarle cual es el numero primo menor");
            entrada = Console.ReadLine();
            numero = Convert.ToInt32(entrada);

            
            for (int M = 1; M <= numero; M++)
            {
                if (numero % M == 0)  
                {
                    
                    contador = contador + 1;
                }
            }

           
            if (contador == 2)  
            {
                Console.WriteLine(numero + " es un número primo y su menor número primo es 2");  
            }
            else
            {
                Console.WriteLine(numero + " no es un número primo y su menor número primo es 2");
            }
        }
    }
}
