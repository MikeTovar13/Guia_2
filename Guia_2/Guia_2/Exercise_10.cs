using System;
using System.Collections.Generic;
using System.Text;

namespace Guia_2 {
    class Exercise_10 {
        double salarioBasico = 908526;
        public void Ejecutar() {
            string repetir;
            do {
                Console.Clear();
                Console.WriteLine("Cálculo de nomina de empleados");
                int n_emp = Utils.readInt("Escriba la cantidad de empleados para caluclar la nomina: ");
                double[][] datos_in = new double[n_emp][];
                string[][] datos_emp = new string[n_emp][];
                for (int i = 0; i < n_emp; i++) {
                    datos_in[i] = new double[6];
                    datos_emp[i] = new string[2];
                    Console.WriteLine("\nIngrese los datos para el empleado {0}", i + 1);

                    Console.Write("Cédula: ");
                    datos_emp[i][0] = Console.ReadLine();
                    Console.Write("Nombre: ");
                    datos_emp[i][1] = Console.ReadLine();

                    datos_in[i][0] = Utils.readDouble("Salario (Valor): ");
                    datos_in[i][1] = Utils.readInt("Días trabajados (Días): ");
                    datos_in[i][2] = Utils.readInt("Horas extras diurnas (Horas): ");
                    datos_in[i][3] = Utils.readInt("Horas extras nocturnas (Horas): ");
                    datos_in[i][4] = Utils.readInt("Horas extras festivas (Horas): ");
                    datos_in[i][5] = Utils.readInt("Horas con recargo nocturno (Horas): ");
                }
                double[][] datos_out = new double[n_emp][];
                for (int i = 0; i < n_emp; i++) {
                    datos_out[i] = this.calcularNomina(datos_in[i]);
                }
                this.mostrarDatosbase(datos_emp, datos_out, n_emp);
                this.mostrarExtras(datos_out, n_emp);
                this.mostrarDeduciones(datos_out, n_emp);
                Console.WriteLine("\n Presiona enter para repetir, escriba NO para volver al menú");
                repetir = Console.ReadLine().ToLower();

            } while (repetir != "no");

        }
        private void mostrarDatosbase(string[][] emp, double[][] d_out, int num_emp) {
            Console.WriteLine("{0, 4}|{1, -25}|{2, -25}|{3, -25:0.0}|{4, -25:0.0}|{5, -25}|",
                    "No.", "Cédula", "Nombre", "Salario", "Auxilio T", "Días");
            for (int i = 0; i < num_emp; i++) {
                Console.WriteLine("{0, 4}|{1, 25}|{2, 25}|{3, 25:C}|{4, 25:C}|{5, 25}|",
                        i + 1, emp[i][0], emp[i][1], d_out[i][0], d_out[i][1], d_out[i][2]);
            }

        }
        private void mostrarExtras(double[][] d_out, int num_emp) {
            Console.WriteLine("\nTotal Devengado");
            Console.WriteLine("{0, 4}|{1, -25}|{2, -25}|{3, -25}|{4, -25}|{5, -25}|{6, -25}|",
                    "No.", "Sueldo", "H. Extras Diurnas", "H. Extras Nocturnas", "H. Extras Festivas", "Recargos Nocturnos", "Total Devengado");
            for (int i = 0; i < num_emp; i++) {
                Console.WriteLine("{0, 4}|{1, 25:C}|{2, 25:C}|{3, 25:C}|{4, 25:C}|{5, 25:C}|{6, 25:C}|",
                        i + 1,  d_out[i][3], d_out[i][4], d_out[i][5], d_out[i][6], d_out[i][7], d_out[i][8]);
            }
        }
        private void mostrarDeduciones(double[][] d_out, int num_emp) {
            Console.WriteLine("\nTotal Deducido");
            Console.WriteLine("{0, 4}|{1, -25}|{2, -25}|{3, -25}|{4, -25}|{5, -25}|",
                    "No.", "Salud", "Pensión", "Fondo Solidaridad", "T. Deducciones", "Neto Pagado");
            for (int i = 0; i < num_emp; i++) {
                Console.WriteLine("{0, 4}|{1, 25:C}|{2, 25:C}|{3, 25:C}|{4, 25:C}|{5, 25:C}|",
                        i + 1, d_out[i][9], d_out[i][10], d_out[i][11], d_out[i][12], d_out[i][13]);
            }
        }
        private double[] calcularNomina(double[] info_emp) {
            // Calculo basico
            double salarioDia = info_emp[0] / 30;
            double valorHora = salarioDia / 8;
            double sueldo = salarioDia * info_emp[1];
            double auxilioTransporte = 0;
            double fondoSolidaridad = 0;

            // Calculos extras
            double hExtraDiurna = ((valorHora * 125) / 100) * (double)info_emp[2]; // cobro al 1,25%
            double hExtraNocturna = ((valorHora * 175) / 100) * (double)info_emp[3]; // cobro al 1,75%
            double hExtraFestiva = ((valorHora * 175) / 100) * (double)info_emp[4]; // cobro al 1,75%;
            double recargoNocturno = ((valorHora * 35) / 100) * (double)info_emp[5];

            if ((double)info_emp[0] <= salarioBasico * 2) {
                auxilioTransporte = 106454;
            }

            if (sueldo >= salarioBasico * 4) {
                fondoSolidaridad = (sueldo * 1) / 100;
            }

            double horasExtras = hExtraFestiva + hExtraDiurna + hExtraNocturna + recargoNocturno;

            double total_1 = sueldo + horasExtras; // Sueldo total

            double salud = (total_1 * 4) / 100;
            double pension = (total_1 * 4) / 100;

            double deducciones = fondoSolidaridad + salud + pension;

            double total_2 = total_1 - deducciones + auxilioTransporte; // Sueldo con deducciones basicas
            ; // Sueldo total con deducciones y extras calculados
            return new double[]{info_emp[0], auxilioTransporte, info_emp[1], sueldo, hExtraDiurna, hExtraNocturna,
                hExtraFestiva, recargoNocturno, total_1, salud, pension, fondoSolidaridad, deducciones, total_2 };

        }
    }
}
