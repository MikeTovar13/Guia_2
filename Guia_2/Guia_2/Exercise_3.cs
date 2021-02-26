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
                double correcta = 0, incorrecta = 0, blanco = 0;
                Console.WriteLine("Programa 3, Te muestra el total de tus respuestas");


                correcta = Utils.readDouble("Ingrese las respuestas correctas");
                correcta = (correcta * 4);

                incorrecta = Utils.readDouble("Ingrese las respuestas incorrectas");
                incorrecta = (incorrecta * -1);

                blanco = Utils.readDouble("Ingrese las respuestas en blanco");
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