using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tarea1Progra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Nombres = new string[] {"Pablo","Jose","Pedro", "Richard"};
            string[] Apellidos = new string[] {"Gonzalez","Rodriguez","Perez","Ramirez"};
            float[] Salario= new float[] {200000,300000,400000,500000};
            int[] Edad = new int[] { 20, 30, 40, 50};
            float IVA = 0, total = 0;
            for (int i = 0; i < Nombres.Length; i++)

            {
                IVA = ((float)(Salario[i] * 0.13));
                total = (Salario[i]+IVA);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Nombre del empleado {i+1}: {Nombres[i]} {Apellidos[i]}, Edad: {Edad[i]}, Salario: {Salario[i]}, IVA: {IVA}, Total: {total}");
            }
            Console.ReadLine();
        }
    }
}
