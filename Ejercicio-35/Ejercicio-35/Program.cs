using System;

namespace Ejercicio_35
{
    class Program
    {
        static int cociente, resto;
        static float dividendo, divisor;
        static string entrada;
        static void Main(string[] args)
        {
            
            cociente = 0;
            resto = 0;
            dividendo = 0;
            divisor = 0;
            entrada = "";

            restasSucesivas();
            Console.ReadKey();
        }

        static private void restasSucesivas()
        {
            Console.WriteLine("Ingrese el primer número: ");  
            entrada = Console.ReadLine();  
            dividendo = Convert.ToSingle(entrada); 

            Console.WriteLine("Ingrese el segundo número: ");  
            entrada = Console.ReadLine();  
            divisor = Convert.ToSingle(entrada); 

           
            if ((dividendo >= 0) && (divisor >= 0)) 
            {
                resto = Convert.ToInt32(dividendo);
                while (resto >= divisor)  
                {
                    resto = resto - Convert.ToInt32(divisor);  
                    cociente = cociente + 1;  

                }

                Console.WriteLine("El cociente es de: " + cociente); 
                Console.WriteLine("El resto es de: " + resto);  
            }
            else
            {
                Console.WriteLine("Usted ha escrito un número negativo");
            }
             }
    }
}
