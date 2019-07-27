using System;

namespace Tarea_Prog._Cajas
{
    class Program
    {
        static void Main(string[] args)
        {
            Cajas nuevaCaja = new Cajas(15,10,15,"rojo");
            nuevaCaja.mostrarDatos1(); // el metodo para mostar

            Cajas nuevaCaja1 = new Cajas(15,10,12,"amarillo");
            nuevaCaja1.mostrarDatos2();
            

            Cajas nuevaCaja2 = new Cajas(15,15,"verde",9,"Caja y más","carton");
            nuevaCaja2.mostrarDatos3();

            Cajas nuevaCaja3 = new Cajas(20,20,"negro",10,"Cuadrada","madera");
            
            nuevaCaja3.mostrarDatos4();

        }
        public class Cajas
        {
            public Cajas(int altura, int ancho, int profundidad, string color)
            {
                this.altura = altura;
                this.Ancho = ancho;
                this.Profundidad = profundidad;
                this.color = color;
            }
            
            public Cajas(int altura, int ancho, string color, int profundidad)
            {
                this.altura = altura;
                this.Ancho = Ancho;
                this.color = color;
                this.Profundidad = profundidad;

            }
            public Cajas(int altura, int ancho, string color, int profundidad, string Nombre_empresa, string Tipo_material)
            {
                this.altura = altura;
                this.Ancho = Ancho;
                this.color = color;
                this.Profundidad = profundidad;
                this.Nombre_Empresa = Nombre_Empresa;
                this.Tipo_material = Tipo_material;
            }
            public Cajas(string color, int ancho, int altura, int profundidad, string Nombre_empresa, string Tipo_material)
                {
                this.color = color;
                this.altura = altura;
                    this.Ancho = Ancho;
                    
                    this.Profundidad = profundidad;
                    this.Nombre_Empresa = Nombre_Empresa;
                    this.Tipo_material = Tipo_material;
                }




            public string color { get; set; }
        public int altura { get; set; }
        public int Ancho { get; set; }
        public int Profundidad { get; set; }
        public string Tipo_material { get; set; }
            public string Estructura { get; set; }
            public string Nombre_Empresa { get; set; }
            public string Lado_Apertura { get; set; }
            

        


            
            public void mostrarDatos1()
        {
                Console.WriteLine(" Altura " + altura + " Ancho " + Ancho + " Profundidad " + Profundidad + "");
                Console.ReadKey();
        }
            public void mostrarDatos2()
            {
                Console.WriteLine(" color " + color + " altura " + altura + " ancho " + Ancho + " Profundidad " + Profundidad + "");
                
                Console.ReadKey();
            }
            public void mostrarDatos3()
            {
                Console.WriteLine(" color " + color + " altura " + altura + " ancho " + Ancho + " Profundidad " + Profundidad + " Tipo de material " + Tipo_material + "");
                Console.WriteLine(" estructura " + Estructura + " Nombre de la empresa " + Nombre_Empresa + " Lado de apertura " + Lado_Apertura + "");
                Console.ReadKey();
            }
            public void mostrarDatos4()
            {
                Console.WriteLine(" color " + color + " altura " + altura + " ancho " + Ancho + " Profundidad " + Profundidad + " Tipo de material " + Tipo_material + "");
                Console.WriteLine(" estructura " + Estructura + " Nombre de la empresa " + Nombre_Empresa + " Lado de apertura " + Lado_Apertura + "");
                Console.ReadKey();
            }
        }
    }
}
