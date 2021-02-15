using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_2
{
    class Exercise_1
    {
        public void Ejecutar()
        {
            string operation;
            do{
                this.menu();
                operation = Console.ReadLine();
                switch (operation)
                {
                    case "0":
                        break;
                    case "+":
                        this.hacer_operacion("suma", this.suma);
                        break;
                    case "-":
                        this.hacer_operacion("resta", this.resta);
                        break;
                    case "*":
                        this.hacer_operacion("multiplicación", this.mult);
                        break;
                    case "/":
                        this.hacer_operacion("división", this.div);
                        break;
                    default:
                        Console.WriteLine("La operación que escogiste es invalida");
                        Console.WriteLine("Presione enter para continuar");
                        Console.ReadLine();
                        break;
                }
                
            } while (operation != "0");
        }
        private double suma(double a, double b) {
            return a + b;
        }
        private double resta(double a, double b)
        {
            return a - b;
        }
        private double mult(double a, double b)
        {
            return a * b;
        }
        private double div(double a, double b)
        {
            return a * b;
        }
        private void hacer_operacion(string operacion, Func<double, double, double> funcion)
        {
            Console.Write("Digita el número 1: ");
            double number_1 = double.Parse(Console.ReadLine());

            Console.Write("Digita el número 2: ");
            double number_2 = double.Parse(Console.ReadLine());
            while (operacion == "división" && number_2 == 0)
            {
                Console.WriteLine("La división por cero (0) no es posible matemáticamente.");
                Console.Write("Digita el número 2: ");
                number_2 = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("La {0} de {1} y {2} es {3}", operacion,number_1, number_2, funcion(number_1, number_2));
            Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
        }
        private void menu()
        {
            Console.Clear();
            Console.WriteLine("Este programa te hace la operación matemática que desees, escoge una opción:");
            Console.WriteLine("Sumar: +");
            Console.WriteLine("Rsstar: -");
            Console.WriteLine("Multiplicar: *");
            Console.WriteLine("Dividir: /");
            Console.WriteLine("Volver: 0");

            Console.WriteLine("Escoge la opción:");
        }
    }

}
