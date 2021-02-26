using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_2 {
    class Exercise_4
    {
        string repetir;
        public void Ejecutar() {
            do
            {
                Console.Clear();
                double ingreso = 0, incentivo = 0, salario = 0;
                int producionSemanal;
                Console.WriteLine("Programa 4, Te muestra si el operario recibe incentivos y cuanto es su salario semanal");

                producionSemanal = Utils.readInt("Ingrese la producción realizada durante la semana: ");

                if (producionSemanal <= 99)
                {
                    // Ingreso 2 pesos
                    ingreso = producionSemanal * 2;
                    // Incentivo 0%
                    incentivo = (ingreso * 0) / 100;

                    Console.WriteLine("Tu producción semanal no es suficiente, lo minímo es 99 unidades, no recibirás incentivos)");
                }
                else if (producionSemanal <= 199)
                {
                    // Ingreso 2 pesos
                    ingreso = producionSemanal * 2;
                    // Incentivo 10%
                    incentivo = (ingreso * 10) / 100;
                }
                else if (producionSemanal <= 299)
                {
                    // Ingreso 2,5 pesos
                    ingreso = producionSemanal * 2.5;
                    // Incentivo 12%
                    incentivo = (ingreso * 12) / 100;
                }
                else if (producionSemanal <= 399)
                {
                    // Ingreso 3 pesos
                    ingreso = producionSemanal * 3;
                    // Incentivo 14%
                    incentivo = (ingreso * 14) / 100;
                }
                else if (producionSemanal >= 400 )
                {
                    // Ingreso 3,5 pesos
                    ingreso = producionSemanal * 3.5;
                    // Incentivo 16%
                    incentivo = (ingreso * 16) / 100;
                }

                Console.WriteLine("Tus incenitvos son: $" + incentivo);
                Console.WriteLine("Tu ingreso es de: $" + ingreso);

                salario = incentivo + ingreso;
                Console.WriteLine("Tu salario de la semana es: $" + salario);

                Console.WriteLine("\n Presiona enter para repetir, escriba NO para volver al menú");
                repetir = Console.ReadLine().ToLower();
            } while (repetir != "no");

        }
    }
}
