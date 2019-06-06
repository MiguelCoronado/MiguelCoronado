using System;

namespace Ejercicio_45
{
    class Program
    {
        static float num1, num2, sumaImpar;
        static string entrada;
        static int conteoPar, conteo, M;
        static void Main(string[] args)
        {
            
            M = 0;
            num1 = 0;
            num2 = 0;
            sumaImpar = 0;
            conteoPar = 0;
            entrada = "";
            conteo = 0;

            ingresoDeNumerosMayorMenor();
            separarNumerosConteoParSumaImpar();
            Console.ReadKey();
        }

        
        static private void ingresoDeNumerosMayorMenor()
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

        static private void separarNumerosConteoParSumaImpar()
        {
            while (M <= num2)  
            {
                Console.WriteLine(M);   

                if (M % 2 == 0)  
                {
                    conteoPar = conteoPar + 1;  
                }
                else
                {
                    sumaImpar = sumaImpar + M;  
                }
                conteo = conteo + 1;
                M = M + 7;   
            }

            
            Console.WriteLine("Hay un total de: " + conteoPar + " números pares");
            Console.WriteLine("La suma de los números impares es de: " + sumaImpar);
            Console.WriteLine("Hay un total de: " + conteo + " números");
        }
    }
}
