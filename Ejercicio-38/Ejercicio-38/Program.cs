using System;

namespace Ejercicio_38
{
    class Program
    {
        static float numInicial, numFinal, diferencia;
        static string entrada;
        static void Main(string[] args)
        {
            
            numInicial = 0;
            numFinal = 0;
            diferencia = 0;
            entrada = "";

            
            Console.WriteLine("Ingrese el número con que se va a iniciar: ");
            entrada = Console.ReadLine();
            numInicial = Convert.ToSingle(entrada);

            Console.WriteLine("Ingrese el número con que se va a finalizar: ");
            entrada = Console.ReadLine();
            numFinal = Convert.ToSingle(entrada);

            Console.WriteLine("Ingrese la diferencia: ");
            entrada = Console.ReadLine();
            diferencia = Convert.ToSingle(entrada);

            //Métodos
            bucleWhileParaProgresionAritmetica();
            identificadorDeNumerosNegativos();
            Console.ReadKey();
        }

        static private void identificadorDeNumerosNegativos()
        {
            
            while ((numInicial < 0) || (numFinal < 0))
            {
                Console.WriteLine("Ingrese nuevamente el número con que se va a iniciar, Positivo ");
                entrada = Console.ReadLine();
                numInicial = Convert.ToSingle(entrada);

                Console.WriteLine("Ingrese nuevamente el número con que se va a finalizar, positivo: ");
                entrada = Console.ReadLine();
                numFinal = Convert.ToSingle(entrada);
            }

            
            while (diferencia < 0)
            {
                Console.WriteLine("Ingrese la diferencia: ");
                entrada = Console.ReadLine();
                diferencia = Convert.ToSingle(entrada);

            }
        }

        static private void bucleWhileParaProgresionAritmetica()
        {
            
            while (numInicial <= numFinal) 
            {
                Console.WriteLine(numInicial);  

                numInicial = numInicial + diferencia;
            }
             }
    }
}
