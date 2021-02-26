using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_2 {
    class Exercise_6 {

        public void Ejecutar() {
            Console.WriteLine("Programa 6, Numero Positivos y Numeros Negativos");

            int num,positivo,negativo,cero,cant,i;
            positivo=0;
            negativo=0;
            cero=0;
            Console.Write("Introduzca Cantidad de Numeros a Evaluar:");
            cant = int.Parse(Console.ReadLine());
            for (i=1; i<=cant;i++)
            {
                Console.Write("Introduzca un Numero Entero:");
                num = int.Parse(Console.ReadLine());
                if (num>0)
                {
                    positivo+=+1;
                }
                else
                if(num<0)
                {
                    negativo+=+1;
                }
                else
                cero+=+1;
            }

            Console.WriteLine("La Cantidad de Positivos Son: " + positivo);
            Console.WriteLine("La Cantidad de Negativos Son: " +negativo);
            Console.WriteLine("La Cantidad de Neutros Son:  " +cero);
            //return 0;
            System.Threading.Thread.Sleep(10000);
        }
    }
}
