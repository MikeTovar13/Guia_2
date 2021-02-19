using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_2
{
    class Exercise_8
    {
        public void Ejecutar()
        {
            string continuar;
            do
            {
                Console.Clear();
                Console.WriteLine("Cálculo de producción de gallinas");
                Console.WriteLine("Ingrese la cantidad de gallinas");
                int gallinas = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de días");
                int dias = int.Parse(Console.ReadLine());
 
                Console.WriteLine("La producción será de {0}", this.calcular_produccion(gallinas, dias));

                Console.WriteLine("Para repetir presione entre, para salir escriba No");
                continuar = Console.ReadLine().ToLower();

            } while (continuar != "no");
        }
        private double calcular_produccion(int x, int n) {
            double prod = 0;
            for (int i = 0; i <= n; i++) {
                prod = prod + Math.Pow(x, i) / this.fact(i);
            }
            return Math.Round(prod, 1);
        
        }
        private double fact(int f) {
            if (f < 2) {
                return 1;
            }
            return f * this.fact(f - 1);
        }
    }
}
