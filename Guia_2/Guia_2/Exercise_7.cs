using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_2 {
    class Exercise_7 {
        public void Ejecutar() {
            string repetir;
            do {
                Console.WriteLine("Programa 7, Promedio de Peso");
                int i, edad, niño, joven, adulto, viejo, personas;
                double peso, peso_niño, peso_joven, peso_adulto, peso_viejo;
                double promedio_niño, promedio_joven, promedio_adulto, promedio_viejo;

                niño = 0;
                joven = 0;
                adulto = 0;
                viejo = 0;
                peso_niño = 0;
                peso_joven = 0;
                peso_adulto = 0;
                peso_viejo = 0;
                promedio_niño = 0;
                promedio_joven = 0;
                promedio_adulto = 0;
                promedio_viejo = 0;

                personas = Utils.readInt("Introduzca la cantidad de personas: ");
                for (i = 1; i <= personas; i++) {
                    Console.WriteLine("\nDatos de la persona: " + i);
                    edad = Utils.readInt("Ingrese la edad: ");
                    peso = Utils.readDouble("Ingrese el peso: ");

                    if (edad < 0) {
                        Console.Write("Edad no válida.");
                    } else if (edad <= 13) {
                        peso_niño += peso;
                        niño++;
                    } else if (edad <= 30) {
                        peso_joven += peso;
                        joven++;
                    } else if (edad <= 60) {
                        peso_adulto = peso_adulto + peso;
                        adulto++;
                    } else {
                        peso_viejo += peso;
                        viejo++;
                    }
                    promedio_niño = this.promedio(niño, peso_niño);
                    promedio_joven = this.promedio(joven, peso_joven);
                    promedio_adulto = this.promedio(adulto, peso_adulto);
                    promedio_viejo = this.promedio(viejo, peso_viejo);
                }
                Console.WriteLine("\nLa cantidad de niños es {0} de {1} personas, su promedio de peso es {2}", niño, personas, promedio_niño);
                Console.WriteLine("La cantidad de jovenes es {0} de {1} personas, su promedio de peso es {2}", joven, personas, promedio_joven);
                Console.WriteLine("La cantidad de adultos es {0} de {1} personas, su promedio de peso es {2}", adulto, personas, promedio_adulto);
                Console.WriteLine("La cantidad de viejos es {0} de {1} personas, su promedio de peso es {2}", viejo, personas, promedio_viejo);
                Console.WriteLine("\n Presiona enter para repetir, escriba NO para volver al menú");
                repetir = Console.ReadLine().ToLower();
            } while (repetir != "no");
        }
        private double promedio(double c, double s) {
            if (c > 0) {
                return s / c;
            }
            return 0;
        }
    }
}
