using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_2 {
    class Exercise_7 {
        public void Ejecutar() {
            Console.WriteLine("Programa 7, Promedio de Peso");
            int i,edad, niño,joven, adulto,viejo, personas;
            double peso,peso_niño, peso_joven, peso_adulto, peso_viejo;
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

            Console.Write("Introduzca Cantidad de Personas:");
            personas = int.Parse(Console.ReadLine());
            for (i = 1; i <= personas; i++) 
            {
                Console.WriteLine("Persona: "+ i);
                Console.Write("Ingresa tu Edad: ");
                edad = int.Parse(Console.ReadLine());

                Console.Write("Ingresa tu Peso: ");
                peso = Double.Parse(Console.ReadLine());
                if (edad < 0)
                {
                    Console.Write("Ingresa tu Edad Correcta: ");
                }
                    else if (edad <= 13)
                    {
                        peso_niño = peso_niño + peso;
                        niño = niño + 1;
                        
                    }
                    else if (edad <= 30)
                    {
                        peso_joven = peso_joven + peso;
                        joven = joven + 1;
                        
                    }
                    else if (edad <= 60)
                    {
                        peso_adulto = peso_adulto + peso;
                        adulto = adulto + 1;
                        
                    }
                        else
                        {
                            peso_viejo = peso_viejo + peso;
                            viejo = viejo + 1;
                            
                        }
            }
            if (niño != 0)
            {
                promedio_niño = peso_niño / niño;
                
            }
            if (joven != 0)
            {
                promedio_joven = peso_joven / joven;
            }
            if (adulto != 0)
            {
                promedio_adulto = peso_adulto / adulto;
            }
            if (viejo != 0)
            {
                promedio_viejo = peso_viejo / viejo;
            }
            


            Console.WriteLine("El promedio del peso de los niños es: "+promedio_niño);
            Console.WriteLine("El promedio del peso de los jovenes es: " + promedio_joven);
            Console.WriteLine("El promedio del peso de los adultos es: " + promedio_adulto);
            Console.WriteLine("El promedio del peso de los viejos es: " + promedio_viejo);
            Console.ReadLine();
        }
    }
}
