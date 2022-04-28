using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Variables
            string dato = "";
          
            string nombre="";


            int ancho1=0;
            int alto1=0;
            int area1=0;

            int ancho2=0;
            int alto2=0;
            int area2=0;

            int areatotal = 0;

            // Solicitamos los valores al usuario

            Console.WriteLine("Buenas tardes");
            Console.WriteLine("Ingrese nombre: ");
            dato = Console.ReadLine();
            nombre = (dato);


            Console.WriteLine("Ingrese 1 habitacion: ");

            Console.WriteLine("Ingrese ancho: ");
            dato = Console.ReadLine();
            ancho1 = Convert.ToInt32(dato);

            Console.WriteLine("Ingrese alto ");
            dato = Console.ReadLine();
            alto1 = Convert.ToInt32(dato);

            Console.WriteLine("el area es : ");
            area1 = ancho1 * alto1;


            Console.WriteLine("Ingrese 2 habitacion: ");

            Console.WriteLine("Ingrese ancho: ");
            dato = Console.ReadLine();
            ancho2 = Convert.ToInt32(dato);

            Console.WriteLine("Ingrese alto ");
            dato = Console.ReadLine();
            alto2 = Convert.ToInt32(dato);

            Console.WriteLine("el area es : ");
            area2 = ancho2 * alto2;


            aretotal = area1 + area2;


            Console.WriteLine("el area de habitacion 1 es {0}: ", area1);

            Console.WriteLine("el area de habitacion 2 es {0}: ", area2);

            Console.WriteLine("el area total es {0}: ", areatotal);




        }
    }
}
