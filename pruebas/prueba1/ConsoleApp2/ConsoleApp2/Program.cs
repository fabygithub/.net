using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            // Variables
            string dato = "";



            string nombre="";
            string apellido="";



            int opcion = 0;
            double cantidad = 0;
            double dolar = 885.88;
            double euro = 896.75;
            double valor = 0;

            // Solicitamos los valores al usuario

            Console.WriteLine("Buenas tardes");
            Console.WriteLine("Ingrese nombre: ");
            dato = Console.ReadLine();
            nombre = (dato);


            Console.WriteLine("Ingrese apellido: ");
            dato = Console.ReadLine();
            apellido = (dato);


            Console.WriteLine("Ingrese valor en pesos");
            dato = Console.ReadLine();
            valor = Convert.ToDouble(dato);



            Console.WriteLine("elegir opcion 1 dolar 2 euros");
            dato = Console.ReadLine();
            opcion = Convert.ToInt32(dato);


            switch (opcion)
            {
                case 1:

                    cantidad = valor / dolar;

                    Console.WriteLine("el resultado es para {0}: {1} la conversion de pesos a divisa {2} ", nombre, apellido, cantidad);


                    break;
                case 2:


                    cantidad = valor / euro;

                    Console.WriteLine("el resultado es para {0}: {1} la conversion de pesos a divisa {2} ", nombre, apellido, cantidad);

                    break;







            }
        }
    }
}

