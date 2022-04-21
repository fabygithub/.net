using System;

namespace OperadorLogicoNot
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             NOT - ! - NO

            A   |   R
            F   |   V
            V   |   F

            Este programa imprime la suma, sólo cuando
            el primer número no sea menor a 10
             
             */

            // Variables

            int a = 0;
            int b = 0;
            int suma = 0;
            string dato = "";

            // Solicitamos los números
            Console.WriteLine("Escriba el 1er número");
            dato = Console.ReadLine();
            a = Convert.ToInt32(dato);

            Console.WriteLine("Escriba el 2do número");
            dato = Console.ReadLine();
            b = Convert.ToInt32(dato);

            // Verificamos que A no sea menor que 10

            if (!(a < 10))
            {
                suma = a + b;
                Console.WriteLine("La suma es {0}", suma);
            }
            else
            {
                Console.WriteLine("El primer número es menor a 10");
            }

        }
    }
}
