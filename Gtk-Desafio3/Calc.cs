using System;
using Gtk;

namespace GtkDesafio3
{
    public class Calc
    {
        struct registro
        {
            public string empleado;
            public string codigo;
            public double horastrabajadas;
        }
        public void Empresa(string NOM,string CODE, int HORA)
        {
            const double afp = 0.0688, isss = 0.0525, renta = 0.1;
            const double caso1 = 1560, caso2 = 2020;
            double sal1, sacarsal = 0, sacarafp = 0, sacarisss = 0, sacarart = 0, sacarsalnet = 0;
            Console.WriteLine("\t  DIGITE LA CANTIDAD DE EMPLEADOS QUE DESEA REGISTRAR...");
            int maxi = int.Parse(Console.ReadLine());
            registro[] data = new registro[maxi];
            Console.Clear();
            for (int i = 0; i < maxi; i++)
            {
                Console.WriteLine("\t  DIGITE EL NOMBRE DEL EMPLEADO {0}...", i + 1);
                data[i].empleado = Console.ReadLine();
                Console.WriteLine("\t  DIGITE EL CODIGO DEL EMPLEADO {0}...", i + 1);
                data[i].codigo = Console.ReadLine();
                Console.WriteLine("\t  DIGITE LAS HORAS TRABAJADAS DEL EMPLEADO {0}...", i + 1);
                data[i].horastrabajadas = double.Parse(Console.ReadLine());
                Console.Clear();
            }
            double HT;
            if (HORA<=160)
            {
                HT = HORA * 9.75;
            }
            else if (HORA>160&&HORA<=200) 
            {
                HT = (160 * 9.75) + ((HORA - 160) * 11.50);
            }
            else if (HORA>200&&HORA<=250)
            {
                HT = (160 * 9.75) + (40 * 11.50) + ((HORA - 200) * 12.50);
            }


            for (int i = 0; i < maxi; i++)
            {
                if (data[i].horastrabajadas <= 160)
                {
                    sal1 = data[i].horastrabajadas * 9.75;
                    double des = sal1 * afp;
                    double des2 = sal1 * isss;
                    double des3 = sal1 * renta;
                    double dest = des + des2 + des3;
                    double salne = sal1 - dest;
                    sacarsal = sal1;
                    sacarafp = des;
                    sacarisss = des2;
                    sacarart = des3;
                    sacarsalnet = salne;
                    Console.WriteLine("\t--------------------------------------------");
                    Console.WriteLine("\tEMPLEADO : {0}", data[i].empleado);
                    Console.WriteLine("\tCODIGO : {0}", data[i].codigo);
                    Console.WriteLine("\tHORAS : {0}", data[i].horastrabajadas);
                    Console.WriteLine("\tAFP : {0}", Math.Round(des), 3);
                    Console.WriteLine("\tISSS : {0}", Math.Round(des2), 3);
                    Console.WriteLine("\tRENTA : {0}", Math.Round(des3), 3);
                    Console.WriteLine("\tSALARIO LIQUIDO : {0}", sal1);
                    Console.WriteLine("\tSALARIO NETO : {0}", Math.Round(salne), 3);
                    Console.WriteLine("\t--------------------------------------------");
                    Console.ReadKey();
                }
                else if (data[i].horastrabajadas > 160 && data[i].horastrabajadas <= 200)
                {
                    double condicional = data[i].horastrabajadas - 160;
                    double calculo = condicional * 11.5;
                    sal1 = caso1 + calculo;
                    double des = sal1 * afp;
                    double des2 = sal1 * isss;
                    double des3 = sal1 * renta;
                    double dest = des + des2 + des3;
                    double salne = sal1 - dest;
                    sacarsal = sal1;
                    sacarafp = des;
                    sacarisss = des2;
                    sacarart = des3;
                    sacarsalnet = salne;
                    Console.WriteLine("\t--------------------------------------------");
                    Console.WriteLine("\tEMPLEADO : {0}", data[i].empleado);
                    Console.WriteLine("\tCODIGO : {0}", data[i].codigo);
                    Console.WriteLine("\tHORAS : {0}", data[i].horastrabajadas);
                    Console.WriteLine("\tAFP : {0}", Math.Round(des), 3);
                    Console.WriteLine("\tISSS : {0}", Math.Round(des2), 3);
                    Console.WriteLine("\tRENTA : {0}", Math.Round(des3), 3);
                    Console.WriteLine("\tSALARIO LIQUIDO : {0}", sal1);
                    Console.WriteLine("\tSALARIO NETO : {0}", Math.Round(salne), 3);
                    Console.WriteLine("\t--------------------------------------------");
                    Console.ReadKey();
                }
                else if (data[i].horastrabajadas > 200 && data[i].horastrabajadas <= 250)
                {
                    double condicional = data[i].horastrabajadas - 200;
                    double calculo = condicional * 12.5;
                    sal1 = caso2 + calculo;
                    double des = sal1 * afp;
                    double des2 = sal1 * isss;
                    double des3 = sal1 * renta;
                    double dest = des + des2 + des3;
                    double salne = sal1 - dest;
                    sacarsal = sal1;
                    sacarafp = des;
                    sacarisss = des2;
                    sacarart = des3;
                    sacarsalnet = salne;
                    Console.WriteLine("\t--------------------------------------------");
                    Console.WriteLine("\tEMPLEADO : {0}", data[i].empleado);
                    Console.WriteLine("\tCODIGO : {0}", data[i].codigo);
                    Console.WriteLine("\tHORAS : {0}", data[i].horastrabajadas);
                    Console.WriteLine("\tAFP : {0}", Math.Round(des), 3);
                    Console.WriteLine("\tISSS : {0}", Math.Round(des2), 3);
                    Console.WriteLine("\tRENTA : {0}", Math.Round(des3), 3);
                    Console.WriteLine("\tSALARIO LIQUIDO : {0}", sal1);
                    Console.WriteLine("\tSALARIO NETO : {0}", Math.Round(salne), 3);
                    Console.WriteLine("\t--------------------------------------------");
                    Console.ReadKey();
                }
            }
        }
    }
}
