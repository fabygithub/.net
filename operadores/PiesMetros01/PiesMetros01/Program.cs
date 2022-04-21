using System;

namespace PiesMetros01
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Desarrollar un programa que convierta de
             metros a pies o de pies a metros, según el
            usuario elija */

            int seleccion = 0;
            string dato = "";
            double metros = 0.0;
            double pies = 0.0;

            // Ahora procedemos a comunicarnos con el usuario

            Console.WriteLine("1. Metros a pies\n2. Pies a Metros");
            Console.Write("¿Qué desea hacer?: ");
            dato = Console.ReadLine();
            seleccion = Convert.ToInt32(dato);

            // Acá determinamos si es metros a pies
            switch (seleccion) {
                case 1:
                    Console.Write("Escriba la cantidad de metros: ");
                    dato = Console.ReadLine();
                    metros = Convert.ToDouble(dato);

                    // Realizamos el cálculo
                    pies = metros * 3.28;

                    // Mostramos el resultado
                    Console.WriteLine("{0} metros son {1} pies", metros, pies);
                    break;

                case 2:

                    // Solicitamos la cantidad de pies
                    Console.Write("Escriba la cantidad de pies: ");
                    dato = Console.ReadLine();
                    pies = Convert.ToDouble(dato);

                    // Realizamos el cálculo
                    metros = pies / 3.28;

                    // Mostramos el resultado
                    Console.WriteLine("{0} pies son {1} metros", pies, metros);

                    break;
            }

        }
    }
}
