using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra2
{
    internal class Clsmenu
    {
        public static void Menu()
        {
            int opcion = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Menú principal");
                Console.WriteLine("1. Inicializar Vectores");
                Console.WriteLine("2. Ingresar Paso Vehicular");
                Console.WriteLine("3. Consulta de vehículos x Número de Placa");
                Console.WriteLine("4. Modificar Datos Vehículos x número de Placa");
                Console.WriteLine("5. Reporte Todos los Datos de los vectores");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                ClsTransacciones C = new ClsTransacciones();
                switch (opcion)
                {
                    case 1:
                        C.Inicializar();
                        break;
                    case 2:
                        C.Ingresar();
                        break;
                    case 3:
                        C.Consulta();
                        break;
                    case 4:
                        C.Modificar();
                        break;
                    case 5:
                        C.Reporte();
                        break;

                    default:

                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();

            } while (opcion != 6);


        }

    }


}

