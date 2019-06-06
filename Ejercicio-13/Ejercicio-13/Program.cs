using System;

namespace Ejercicio_13
{
    class Program
    {
        static int conteo;
        static float M, suma, numero;
        static string entrada;
        static void Main(string[] args)
        {
            M = 0;  
            conteo = 0;  
            suma = 0;  
            numero = 0;  
            entrada = "";  

            numeroIngresadoMenorQue500();
            sumaConteo8PosicionesHasta500();
            Console.ReadKey();
        }

        static private void numeroIngresadoMenorQue500()
        {
            Console.WriteLine("Ingrese un número menor que 500: ");  
            entrada = Console.ReadLine();  

            numero = Convert.ToSingle(entrada);  

            while (numero > 500) 
            {
                Console.WriteLine("El número ingresado es mayor que 500, ingrese un número menor que 500: ");  
                                                                                                                
                entrada = Console.ReadLine(); 
                numero = Convert.ToSingle(entrada);  

            }
        }

        static private void sumaConteo8PosicionesHasta500()
        {
            M = numero;  
            while (M < 500)  
            {
                Console.WriteLine(M);  
                suma = suma + M;  
                M = M + 8;  
                conteo = conteo + 1;  
            }

            Console.WriteLine("Hay un total de: " + conteo + " numeros desde " + numero + " hasta 500 separados en 8 posiciones");  
            Console.WriteLine("La suma total es de: " + suma);
        }
    }
}
