using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_2
{
    class Exercise_3
    {
        string repetir;
        public void Ejecutar()
        {
            do
            {
                double num, correcta = 0, incorrecta = 0, blanco = 0;
                Console.WriteLine("Programa 3, Te muestra el total de tus respuestas");


                Console.WriteLine("Ingrese las respuestas correctas");
                correcta = double.Parse(Console.ReadLine());
                correcta = (correcta * 4);

                Console.WriteLine("Ingrese las respuestas incorrectas");
                incorrecta = double.Parse(Console.ReadLine());
                incorrecta = (incorrecta * -1);

                Console.WriteLine("Ingrese las respuestas blanco");
                blanco = double.Parse(Console.ReadLine());
                blanco = (0);

                Console.WriteLine("Tu puntaje de respuestas correctas es: {0}", correcta);
                Console.WriteLine("Tu puntaje de respuestas incorrectas es: {0}", incorrecta);
                Console.WriteLine("Tu puntaje de respuestas blanco es: {0}", blanco);
                double total = correcta + incorrecta + blanco;
                Console.WriteLine("Tu puntaje total es: {0}", total);


                Console.WriteLine("\n Presiona enter para repetir, escriba NO para volver al menú");
                repetir = Console.ReadLine().ToLower();
            }

            while (repetir != "no");

        }
    }
}