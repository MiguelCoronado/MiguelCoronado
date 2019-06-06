using System;

namespace Ejericico_23
{
    class Program
    {
        static int num1, num2, conteo, conteoPar, sumaImpar;
        static string entrada;
        static void Main(string[] args)
        {
            num1 = 0;  
            num2 = 0; 
            conteo = 0;  
            conteoPar = 0;  
            sumaImpar = 0;  
            entrada = "";  

            ingresoDeDatos();
            conteoSumaImparYConteoPar();
            Console.ReadKey();
        }

        static private void ingresoDeDatos()
        {
            Console.WriteLine("Ingrese el primer número: ");  
            entrada = Console.ReadLine();  
            num1 = Convert.ToInt32(entrada); 

            Console.WriteLine("Ingrese el segundo número: "); 
            entrada = Console.ReadLine();  
            num2 = Convert.ToInt32(entrada); 
        }

        static private void conteoSumaImparYConteoPar()
        {
            if (num1 < num2)  
            {
                while (num1 <= num2)  
                {
                    Console.WriteLine(num1);  
                    if (num1 % 2 == 0)  
                    {
                        conteoPar = conteoPar + 1;  
                    }
                    else
                    {
                        sumaImpar = sumaImpar + num1; 
                    }

                    conteo = conteo + 1;  
                    num1 = num1 + 1; 
                }
            }
            else
            {
                while (num2 <= num1) 
                {
                    Console.WriteLine(num2);   
                    if (num2 % 2 == 0)  
                        conteoPar = conteoPar + 1;  
                    
                    else
                    {
                        sumaImpar = sumaImpar + num1;  
                    }

                    conteo = conteo + 1;  
                    num2 = num2 + 1; 
                }

            }

            Console.WriteLine("Hay un total de: " + conteo + " números naturales");  
            Console.WriteLine("Hay un total de: " + conteoPar + " números pares");
            Console.WriteLine("La suma total de los números impares es de: " + sumaImpar);
        }
    }
}
