using System;

namespace OperadorLogicoOr
{
    class Program
    {
        static void Main(string[] args)
        {
            // OR - || - O
            /* Es verdadero si al menos uno es verdadero
             A  B   |   R
             F  F   |   F
             F  V   |   V
             V  F   |   V
             V  V   |   V
             
             */

            // Este programa imprime la suma, si hay un número menor a 10

            // Variables
            int a = 0;
            int b = 0;
            int suma = 0;
            string dato = "";

            // Solicitamos los números

            Console.WriteLine("Escriba el 1er número: ");
            dato = Console.ReadLine();
            a = Convert.ToInt32(dato);

            Console.WriteLine("Escriba el 2do número: ");
            dato = Console.ReadLine();
            b = Convert.ToInt32(dato);

            // 

            if (a < 10 || b < 10)
            {
                // Sumamos
                suma = a + b;

                Console.WriteLine("La suma es {0}",suma);
            }
            else
            {
                Console.WriteLine("Ningún número fue menor a 10");
            }
        }
    }
}
