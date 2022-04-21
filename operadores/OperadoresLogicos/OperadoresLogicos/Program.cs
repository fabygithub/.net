using System;

namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            AND - && - Y
             Sólo es verdadero cuando ambos son verdaderos
            A   B   |   R
            F   F   |   F
            F   V   |   F
            V   F   |   F
            V   V   |   V
            
            */

            // Este programa imprime la suma, sólo cuando
            // los dos números ingresados sean menores a 10

            // Variables

            int a = 0;
            int b = 0;
            int suma = 0;
            string dato = "";

            // Solicitamos los números

            Console.WriteLine("Ingrese el 1er número: ");
            dato = Console.ReadLine();
            a = Convert.ToInt32(dato);

            Console.WriteLine("Ingrese el 2do número: ");
            dato = Console.ReadLine();
            b = Convert.ToInt32(dato);

            // Verificamos que A sea menor que 10 y B sea menor que 10
            // ampersand
            if (a < 10 && b < 10)
            {
                suma = a + b;

                Console.WriteLine("La suma es {0}", suma);
            }
            else
            {
                Console.WriteLine("El primer o segundo número es mayor a 10");
            }
        }
    }
}
