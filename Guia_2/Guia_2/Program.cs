using System;

namespace Guia_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string program; 
            Console.WriteLine("Solución Guía #2");

            Console.WriteLine("1. Operaciones matemáticas");
            Console.WriteLine("2. Funciones matemáticas");
            Console.WriteLine("3. Validar respuestas");
            Console.WriteLine("4. Salario promedio");
            Console.WriteLine("5. Estación climática");
            Console.WriteLine("6. Algoritmo de suma");
            Console.WriteLine("7. Estadistica de pesos personas");
            Console.WriteLine("8. Producción de granja (Huevos)");
            Console.WriteLine("9. Matriz de estudiantes");
            Console.WriteLine("10. Nómina de empleados");
            Console.WriteLine("");
            Console.WriteLine("Escoge el programa:");
            program = Console.ReadLine();

            switch (program) {
                case "1":
                    Exercise_1 ex1 = new Exercise_1();
                    ex1.Ejecutar();
                    break;
                case "2":
                    Exercise_2 ex2 = new Exercise_2();
                    ex2.Ejecutar();
                    break;
                case "3":
                    Exercise_3 ex3 = new Exercise_3();
                    ex3.Ejecutar();
                    break;
                case "4":
                    Exercise_4 ex4 = new Exercise_4();
                    ex4.Ejecutar();
                    break;
                case "5":
                    Exercise_5 ex5 = new Exercise_5();
                    ex5.Ejecutar();
                    break;
                case "6":
                    Exercise_6 ex6 = new Exercise_6();
                    ex6.Ejecutar();
                    break;
                case "7":
                    Exercise_7 ex7 = new Exercise_7();
                    ex7.Ejecutar();
                    break;
                case "8":
                    Exercise_8 ex8 = new Exercise_8();
                    ex8.Ejecutar();
                    break;
                case "9":
                    Exercise_9 ex9 = new Exercise_9();
                    ex9.Ejecutar();
                    break;
                case "10":
                    Exercise_10 ex10 = new Exercise_10();
                    ex10.Ejecutar();
                    break;
            }
            
        }
    }
}
