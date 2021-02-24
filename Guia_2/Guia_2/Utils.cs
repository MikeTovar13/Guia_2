using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_2 {
    class Utils {
        public static int readInt(string texto) {
            int x;
            bool correcto = true;
            do {
                if (!correcto) Console.WriteLine("Debe escribir un número entero, intente de nuevo");
                Console.Write(texto);
                string dato = Console.ReadLine();
                correcto = int.TryParse(dato, out x);
            } while (!correcto);
            return x;
        }
        public static double readDouble(string texto) {
            double x;
            bool correcto = true;
            do {
                if (!correcto) Console.WriteLine("Debe escribir un número, intente de nuevo");
                Console.Write(texto);
                string dato = Console.ReadLine();
                correcto = double.TryParse(dato, out x);
            } while (!correcto);
            return x;
        }
        public static float readFloat(string texto) {
            float x;
            bool correcto = true;
            do {
                if (!correcto) Console.WriteLine("Debe escribir un número, intente de nuevo");

                Console.Write(texto);
                string dato = Console.ReadLine();
                correcto = float.TryParse(dato, out x);
            } while (!correcto);
            return x;
        }
    }
}
