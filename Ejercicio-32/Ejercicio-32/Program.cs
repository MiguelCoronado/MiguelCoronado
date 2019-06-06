using System;

namespace Ejercicio_32
{
    class Program
    {
        static string entrada;
        static float num1, num2, suma;
        static int M, conteo;
        static void Main(string[] args)
        {
            
            entrada = "";
            M = 0;
            num1 = 0;
            num2 = 0;
            conteo = 0;
            suma = 0;

            ingresoDeNumeros();
            multiplosDe2();
            Console.ReadKey();
        }

        static private void ingresoDeNumeros()
        {
            Console.WriteLine("Ingrese un número: ");  
            entrada = Console.ReadLine();  
            num1 = Convert.ToSingle(entrada);  
            M = Convert.ToInt32(num1); 

            Console.WriteLine("Ingrese un número mayor que: " + num1);  
            entrada = Console.ReadLine();  
            num2 = Convert.ToSingle(entrada); 

            while (num2 < num1)
            {
                Console.WriteLine("El número ingresado es menor que: " + num1 + " ingrese nuevamente un número mayor que " + num1);   //Se solicita un número.
                entrada = Console.ReadLine();  
                num2 = Convert.ToSingle(entrada);  
            }
        }

        static private void multiplosDe2()
        {
            while (M <= num2)  
            {
                if (M % 2 == 0) 
                {
                    Console.WriteLine(M);  
                    suma = suma + M; 
                    conteo = conteo + 1;  
                }

                M = M + 1;  
            }

            
            Console.WriteLine("Hay un total de " + conteo + " múltiplos de 2");
            Console.WriteLine("La suma de los múltiplos de 2 es de: " + suma);
        }
    }
}
