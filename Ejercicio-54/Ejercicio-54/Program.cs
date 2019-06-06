using System;

namespace Ejercicio_54
{
    class Program
    {
        static int M, contador;
        static float num1, num2;
        static string entrada;
        static void Main(string[] args)
        {
            
            M = 0;
            contador = 1;
            num1 = 0;
            num2 = 0;
            entrada = "";

            restasSucesivas();
            Console.ReadKey();
        }

        static private void restasSucesivas()
        {
            Console.WriteLine("Ingrese el primer número: ");  
            entrada = Console.ReadLine();  
            num1 = Convert.ToSingle(entrada);  

            Console.WriteLine("Ingrese el segundo número: ");  
            entrada = Console.ReadLine();  
            num2 = Convert.ToSingle(entrada);  

            
            if ((num1 >= 0) && (num2 >= 0)) 
            {
                while (contador <= num1)  
                {
                    contador = contador + 1;  
                    M = M + Convert.ToInt32(num2);  
                }

                Console.WriteLine("El producto de los dos números mediante sumas suceivas es de: " + M);  
            }
            else
            {
                Console.WriteLine("Usted ha escrito un número negativo");
            }
       }
    }
}
