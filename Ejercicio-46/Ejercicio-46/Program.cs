using System;

namespace Ejercicio_46
{
    class Program
    {
        static int M, conteoM, sumaM, num1, num2;
        static string entrada;
        static void Main(string[] args)
        {
            
            M = 0;
            conteoM = 0;
            sumaM = 0;
            num1 = 0;
            num2 = 0;
            entrada = "";

            ingresoDeNumerosYBucleNegativos();
            numeroMayoroMenor();
            bucleParaImpresionDeMultiplos2();
            Console.ReadKey();
        }

        static private void ingresoDeNumerosYBucleNegativos()
        {
            //Ingreso de datos.
            Console.WriteLine("Ingrese el primer número entero positivo: ");  
            entrada = Console.ReadLine();  
            num1 = Convert.ToInt32(entrada);  
            M = num1;  

            Console.WriteLine("Ingrese un número entero positivo mayor que: " + num1);  
            entrada = Console.ReadLine();  
            num2 = Convert.ToInt32(entrada);  

            
            while ((num1 < 0) || (num2 < 0))
            {
                Console.WriteLine("Usted ingresó números negativos");  
                Console.WriteLine("Ingrese el primer número entero positvo: ");  
                entrada = Console.ReadLine();  
                num1 = Convert.ToInt32(entrada);  
                M = num1;  

                Console.WriteLine("Ingrese un número entero positivo mayor que: " + num1);  
                entrada = Console.ReadLine();  
                num2 = Convert.ToInt32(entrada);  
            }


        }

        static private void numeroMayoroMenor()
        {
            
            while (num2 < num1)
            {
                Console.WriteLine("El número ingresado es menor que: " + num1 + " ingrese nuevamente un número mayor que " + num1);   //Se solicita un número.
                entrada = Console.ReadLine();  
                num2 = Convert.ToInt32(entrada);  
            }
        }

        static private void bucleParaImpresionDeMultiplos2()
        {
            
            while (M <= num2)  
            {
                if (M % 2 == 0)  
                {
                    Console.WriteLine(M);  
                    sumaM = sumaM + M;  
                    conteoM = conteoM + 1;  
                    M = M + 2;  
                }
                else
                {
                    num1 = num1 + 1;  
                    M = num1;  
                    Console.WriteLine(M); 
                    sumaM = sumaM + M; 
                    conteoM = conteoM + 1;  
                    M = M + 2;  

                }
            }

            
            Console.WriteLine("Hay un total de: " + conteoM + " múltiplos de 2");
            Console.WriteLine("La suma total de los múltiplos de 2 es de: " + sumaM);
        }
    }
}
