using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_2 {
    class Exercise_10 {
        public void Ejecutar() {
            Dictionary<string, Dictionary<string, object>> info_empleados = new Dictionary<string, Dictionary<string, object>>();
            string repetir; 
            do {

                Console.WriteLine("Cálculo de nomina de empleados");
                Console.WriteLine("Escriba la cantidad de empleados para caluclar la nomina");
                int n_emp = int.Parse(Console.ReadLine());
                info_empleados["emp1"] = new Dictionary<string, object>();
                info_empleados["emp1"]["salario"] = 1000;
                Console.WriteLine("Presiones enter para repetir, escriba NO para volver al menú");
                repetir = Console.ReadLine();
            } while (repetir != "no");
        
        }
    }
}
