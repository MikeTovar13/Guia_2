using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_2
{
    class Exercise_1
    {
        public void Ejecutar()
        {
            float number_1, number_2, result;
            string operation;

            // Inicialization vars
            result = 0;

            Console.WriteLine("Este programa te hace la operación matemática que desees, escoge una opción:");
            Console.WriteLine("Sumar: +");
            Console.WriteLine("Rsstar: -");
            Console.WriteLine("Multiplicar: *");
            Console.WriteLine("Dividir: /");

            Console.WriteLine("Escoge la operación:");
            operation = Console.ReadLine();

            Console.WriteLine("Digita el número 1:");
            number_1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digita el número 2:");
            number_2 = float.Parse(Console.ReadLine());

            if (operation == "+") {
                result = number_1 + number_2;
            } else if (operation == "-") {
                result = number_1 - number_2;
            } else if (operation == "*") {
                result = number_1 * number_2;
            } else if (operation == "/") {
                if (number_2 != 0) {
                    result = number_1 / number_2;
                } else {
                    result = float.NaN;
                }
            } else {
                Console.WriteLine("La operación que escogiste es invalida");
            }

            if (!float.IsNaN(result)) {
                Console.WriteLine("Tu resultado es: " + Math.Round(result, 1));
            } else {
                Console.WriteLine("La división por cero (0) no es posible matemáticamente.");
            }
        }
    }
}
