using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_2
{
    public class Exercise_2
    {
        public void Ejecutar()
        {

            double num, resultado, resultado1, resultado2, resultado3, res, res1, res2;
            Console.Clear();
            Console.WriteLine("FUNCIONES MATEMATICAS!");
            Console.WriteLine("Calculemos la raiz de un numero!");
            Console.WriteLine("Ingrese el numero");
            num = Double.Parse(Console.ReadLine());
            resultado = Math.Sqrt(num);
            Console.WriteLine("La raiz es {0}", resultado);

            Console.WriteLine("Calculemos la funcion exponencial (Elevado a la 2)!");
            Console.WriteLine("Ingrese el numero");
            num = Double.Parse(Console.ReadLine());
            resultado1 = Math.Pow(num, 2);
            Console.WriteLine("La respuesta es {0}", resultado1);

            Console.WriteLine("Calculemos la funcion exponencial (Elevado a la 3)!");
            Console.WriteLine("Ingrese el numero");
            num = Double.Parse(Console.ReadLine());
            resultado3 = Math.Pow(num, 3);
            Console.WriteLine("La respuesta es {0}", resultado3);

            Console.WriteLine("Calculemos el valor Absoluto!");
            Console.WriteLine("Ingrese el numero");
            num = Double.Parse(Console.ReadLine());
            resultado2 = Math.Abs(num);
            Console.WriteLine("El valor absoluto es {0}", resultado2);

            Console.WriteLine("Calculemos el SENO de un numero");
            Console.WriteLine("Ingrese el numero");
            num = Double.Parse(Console.ReadLine());
            res = Math.Sin(num);
            Console.WriteLine("El seno es {0}", res);

            Console.WriteLine("Calculemos el COSENO de un numero");
            Console.WriteLine("Ingrese el numero");
            num = Double.Parse(Console.ReadLine());
            res1 = Math.Cos(num);
            Console.WriteLine("El coseseno es {0}", res1);

            Console.WriteLine("Calculemos el TANGENTE de un numero");
            Console.WriteLine("Ingrese el numero");
            num = Double.Parse(Console.ReadLine());
            res2 = Math.Tan(num);
            Console.WriteLine("La tangente es {0}", res2);


            string ladoA;
            string ladoB;

            Console.WriteLine("Calculemos la hipotenusa!");
            Console.WriteLine("Ingresa el valor del lado A");
            ladoA = Console.ReadLine();
            Console.WriteLine("Ingresa el valor del lado B");
            ladoB = Console.ReadLine();

            float a = Convert.ToSingle(ladoA);
            float b = Convert.ToSingle(ladoB);
            double h2 = Math.Pow(a, 2) + Math.Pow(b, 2);
            double h = Math.Sqrt(h2);

            Console.WriteLine("La hipotenusa es {0}", h);

            Console.WriteLine("Calculemos Cubo perfecto!");
            Console.WriteLine("Ingresa el numero, para verificar el cubo perfecto");
            int n = int.Parse(Console.ReadLine());
            if (CuboPerfecto(n) == true)
                Console.WriteLine("Es un cubo perfecto");
            else
                Console.WriteLine("No es un cubo perfecto");

            Console.WriteLine("Calculemos el area de una circunferencia!");
            Console.WriteLine("Ingresa el radio de la circunferencia");
            double radio = double.Parse(Console.ReadLine());
            Console.WriteLine(Area(radio));


            static bool CuboPerfecto(int n)
            {
                double raiz = Math.Pow((double)n, 1.0 / 3.0);
                double modulo = (double)n % raiz;
                if (modulo == 0.0)
                {
                    return true;
                }
                else
                    return false;
            }

            static double Area(double radio)
            {
                double area = Math.PI * Math.Pow(radio, 2);
                return area;
            }
          
            }
        }
    }
