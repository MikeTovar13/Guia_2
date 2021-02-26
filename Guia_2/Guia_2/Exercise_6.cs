using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_2 {
    class Exercise_6 {

        public void Ejecutar() {

            string repetir = "";
            do {
                Console.Clear();
                Console.WriteLine("Programa 6, Numero Positivos y Numeros Negativos");
                double num;
                int positivo = 0;
                int negativo = 0;
                int cero = 0;
                int cant;

                double numPositivos = 0;
                double numNegativos = 0;

                cant = Utils.readInt("Introduzca Cantidad de Numeros a Evaluar: ");

                for (int i = 1; i <= cant; i++) {

                    num = Utils.readDouble("Introduzca un Numero Entero: ");
                    if (num > 0) {
                        positivo += 1;
                        numPositivos += num;
                    } else
                    if (num < 0) {
                        negativo += 1;
                        numNegativos += num;
                    } else {
                        cero++;
                    }
                }

                Console.WriteLine("La cantidad de positivos son {0} y suman en total {1}.", positivo, numPositivos);
                Console.WriteLine("La cantidad de negativos son {0} y suman en total {1}.", negativo, numNegativos);
                Console.WriteLine("La cantidad de neutros son {0} y suman cero.", cero);

                Console.WriteLine("\n Presiona enter para repetir, escriba NO para volver al menú");
                repetir = Console.ReadLine().ToLower();

            } while (repetir != "no");
            
        }
    }
}
