using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_2 {
    class Exercise_9 {
        public void Ejecutar() {
            string opcion;
            do {
                Console.Clear();
                Console.WriteLine("Promedios por materia y por estudiante\n");

                int materias = Utils.readInt("Escribe la cantidad de materias: ");
                int estudiantes = Utils.readInt("Escribe la cantidad de estudiantes: ");

                float[][] matriz = new float[materias][];
                for (int i = 0; i < materias; i++) {
                    matriz[i] = new float[estudiantes];
                    for (int j = 0; j < estudiantes; j++) {
                        matriz[i][j] = Utils.readFloat("Escribe la nota de la materia "+(i+1)+" para el estudiante "+(j+1)+"\n Usar , para los decimales: ");
                    }
                }
                this.mostrar_tabla(matriz, materias, estudiantes);

                this.promedio_materia(matriz, materias, estudiantes);
                this.promedio_estudiante(matriz, materias, estudiantes);
                Console.WriteLine("\nPresiona enter para continuar, o escriba NO para volver al menú principal");
                opcion = Console.ReadLine().ToLower();
            } while (opcion != "no");
        }
        private void promedio_materia(float[][] m, int r, int c) {
            Console.WriteLine("\n****Promedio por materias****");
            for (int i = 0; i < r; i++) {
                float promedio = 0;
                for (int j = 0; j < c; j++) {
                    promedio += m[i][j];
                }
                Console.WriteLine("Promedio M-{0} es {1,5}", i + 1, Math.Round(promedio / c, 1));

            }
        }
        private void promedio_estudiante(float[][] m, int r, int c) {
            Console.WriteLine("\n****Promedio por estudiantes****");
            for (int i = 0; i < c; i++) {
                float promedio = 0;
                for (int j = 0; j < r; j++) {
                    promedio += m[j][i];
                }
                Console.WriteLine("Promedio E-{0} es {1,5}", i + 1, Math.Round(promedio / r, 1));

            }
        }
        private void mostrar_tabla(float[][] m, int r, int c) {
            Console.WriteLine();
            Console.Write("{0,5} |", "-");
            for (int j = 0; j < c; j++) {
                Console.Write(" {0,5} | ", "E-" + (j + 1));
            }
            Console.WriteLine();
            for (int i = 0; i < r; i++) {
                Console.Write("|{0,5}|", "M-" + (i + 1));
                for (int j = 0; j < c; j++) {
                    Console.Write(" {0,5} | ", m[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
