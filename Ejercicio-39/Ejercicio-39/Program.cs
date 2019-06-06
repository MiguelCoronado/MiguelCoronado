using System;

namespace Ejercicio_39
{
    class Program
    {
        static int pre, pos, val;
        static float numero;
        static string entrada;
        static void Main(string[] args)
        {
            //Asgnaciónd de varibales.
            val = 0;
            pre = 0;
            pos = 1;
            numero = 0;
            entrada = "";

            condicionalParaGeerarSerieFibonacci();
            Console.ReadKey();
        }

        static private void condicionalParaGeerarSerieFibonacci()
        {
            
            Console.WriteLine("Ingrese una cantidad de términos que quiere generar: ");
            entrada = Console.ReadLine();
            numero = Convert.ToSingle(entrada);

            
            Console.WriteLine(pre + "  " + pos);

            
            for (int M= 3; M <= numero; M++)  
            {
                val = pre + pos;  
                pre = pos;  
                pos = val; 

                Console.WriteLine(val);
            }
        }
    }
}
