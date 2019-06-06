using System;

namespace Ejercicio_15
{
    class Program
    {
        static int potencia;
        static string entrada;
        static float M, suma, numero;
        static double datos;
        static void Main(string[] args)
        {
            M = 0;   
            entrada = "";  
            numero = 0;   

            ingresoDeNumeroMenor100();
            cuadradosDeNumeros4Posiciones();
            Console.ReadKey();
        }

        static private void ingresoDeNumeroMenor100()
        {
            Console.WriteLine("Ingrese un número menor que 100: ");  
            entrada = Console.ReadLine();  
            numero = Convert.ToSingle(entrada);  

            while (M > 100) 
            {
                Console.WriteLine("El número ingresado es mayor que 100, ingrese un número menor que 100: "); 
                entrada = Console.ReadLine();  
                numero = Convert.ToSingle(entrada);  
            }
        }

        static private void cuadradosDeNumeros4Posiciones()
        {
            M = numero;  
            while (M <= 100)  
            {
                datos = Math.Pow(M, 2); 
                potencia = Convert.ToInt32(datos);  
                Console.WriteLine(M);  
                suma = suma + potencia;  
                M = M + 4;  
            }

            Console.WriteLine("La suma de los cuadrados que estan separados entres sí cuatro posiciones es de: " + suma);

        }
    }
}
