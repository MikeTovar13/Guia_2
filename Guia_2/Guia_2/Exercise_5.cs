using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guia_2 {
    class Exercise_5
    {
        string repetir;
        int nErrors = 0;
        double tempMax= 0, tempMin= 0, med=0, max=0, min=0;
        public void Ejecutar() {
           do
            {
                Console.Clear();
                Console.WriteLine("Programa 5, Calculos estación climática ");
                int nDias = Utils.readInt("Ingrese la cantidad de días que vas a registrar las termperaturas: ");
                double[][] temps = new double[nDias][];
                for (int i = 0; i < nDias; i++)
                {
                    temps[i] = new double[2];
                    Console.WriteLine("Temperatura del día {0}", i+1);
                    tempMax = Utils.readDouble("Temperatura máxima: ");
                    if (tempMax == 9)
                    {
                        tempMax = Utils.readDouble("Temperatura invalida, ingrese una temperatura máxima: ");
                        nErrors++;
                    }
                    tempMin = Utils.readDouble("Temperatura minima: ");
                    if (tempMin == 9) {
                        tempMin = Utils.readDouble("Temperatura invalida, ingrese una temperatura minima: ");
                        nErrors++;
                    } else if (tempMin > tempMax)
                    {
                        nErrors++;
                        tempMin = Utils.readDouble("La temperatura debe ser menor a la máxima, ingrese una temperatura minima: ");
                    }
                    temps[i][0] = tempMax;
                    temps[i][1] = tempMin;
                }

                
                Console.WriteLine("Temperatura máxima | Temperatura minima");
                for (int ii = 0; ii < nDias; ii++)
                {
                    Console.WriteLine("{0} {1}", temps[ii][0], temps[ii][1]);
                    this.calcularMedia(temps[ii]);
                    this.calcularMaxima(temps[ii]);
                    this.calcularMinima(temps[ii]);
                }
                Console.WriteLine("Temperatura media: {0}", med);
                Console.WriteLine("Temperatura máxima {0}", max);
                Console.WriteLine("Temperatura minima {0}", min);
                Console.WriteLine("Cantidad de errores: {0}", nErrors);

                Console.WriteLine("\n Presiona enter para repetir, escriba NO para volver al menú");
                repetir = Console.ReadLine().ToLower();
            } while (repetir != "no");

        }

        private void calcularMedia(double[] temps)
        {
             med = temps.Average();
            //Console.WriteLine("El promedio es {0}", med);
        }

        private void calcularMaxima(double[] temps)
        {
            max = temps.Max();
            //Console.WriteLine("La temperatura máxima es {0}", max);

        }

        private void calcularMinima(double[] temps)
        {
            min = temps.Min();
            //Console.WriteLine("La temperatura minima  es {0}", min);

        }

    }
}
