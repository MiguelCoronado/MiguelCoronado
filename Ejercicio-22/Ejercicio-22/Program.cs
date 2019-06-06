using System;

namespace Ejercicio_22
{
    class Program
    {
        static string entrada;
        static float numero, numMayor, numMenor;
        static int M;
        static void Main(string[] args)
        {
            M = 1; 
            numero = 0;  
            numMayor = 0;  
            numMenor = 9999;  
            entrada = "";  


            numeroMayorMenorEnSerieDeNumero();
            Console.ReadKey();
        }

        static private void numeroMayorMenorEnSerieDeNumero()
        {
            while (M <= 5) 
            {
                Console.WriteLine("Ingrese un número: ");  
                entrada = Console.ReadLine(); 
                numero = Convert.ToSingle(entrada);  



                if (numero > numMayor) 
                {
                    numMayor = numero;  
                }

                if (numero < numMenor)   
                {
                    numMenor = numero;  
                }

                M = M + 1;  
            }

            Console.WriteLine("El número mayor es: " + numMayor);  
            Console.WriteLine("El número menor es: " + numMenor);
        }
    }
}
