using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra2
{
    internal class ClsTransacciones
    {
        static string[] NumeroFactura = new string[15];
        static string[] NumeroPlaca = new string[15];
        static string[] Fecha = new string[15];
        static string[] Hora = new string[15];
        static int[] TipoVehiculo = new int[15];
        static int[] NumeroCaseta = new int[15];
        static float[] MontoPagar = new float[15];
        static float[] Pago = new float[15];
        static float[] Vuelto = new float[15];
        static int N = NumeroFactura.Length;

        static float[] Costos = { 500, 700, 2700, 3700 };

        static int Nvehiculo = 0;

        public void Inicializar()
        {
            for (int i = 0; i < N; i++)
            {
                NumeroFactura[i] = "";
                NumeroPlaca[i] = "";
                Fecha[i] = "";
                Hora[i] = "";
                TipoVehiculo[i] = 0;
                NumeroCaseta[i] = 0;
                MontoPagar[i] = 0;
                Pago[i] = 0;
                Vuelto[i] = 0;
            }
        }

        public void Ingresar()
        {

            bool continuar = false;
            do
            {
                if (Nvehiculo < N)
                {

                    Console.WriteLine($"Factura N#{Nvehiculo + 1}");
                    NumeroFactura[Nvehiculo] = $"{Nvehiculo}";
                    Console.WriteLine("Escriba el numero de placa del vehiculo: ");
                    NumeroPlaca[Nvehiculo] = Console.ReadLine();
                    Console.WriteLine("Escriba la fecha de hoy (D/M/A): ");
                    Fecha[Nvehiculo] = Console.ReadLine();
                    Console.WriteLine("Escriba la hora actual (h:m): ");
                    Hora[Nvehiculo] = Console.ReadLine();
                    int op1, op2;

                    do
                    {
                        Console.WriteLine("Escriba el tipo de vehiculo \n1= Moto\n2= Vehículo Liviano\n3 =Camión o Pesado \n4=Autobús): ");
                        op1 = int.Parse(Console.ReadLine());

                        if (op1 < 5)
                        {
                            TipoVehiculo[Nvehiculo] = op1;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Error, intente otra vez :(");
                        }
                    } while (op1 != 4);

                    do
                    {
                        Console.WriteLine("Escriba el numero de caseta (1,2 o 3) ");
                        op2 = int.Parse(Console.ReadLine());
                        if (op2 < 4)
                        {
                            NumeroCaseta[Nvehiculo] = op2;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Error, intente otra vez :(");
                        }
                    } while (op2 != 3);
                    float peaje = Costos[TipoVehiculo[Nvehiculo] - 1];
                    Console.WriteLine($"Monto a Pagar: {peaje} colones");
                    float efectivo;
                    do

                    {
                        Console.WriteLine("Paga con: ");
                        efectivo = float.Parse(Console.ReadLine());
                        if (efectivo > (peaje - 1))
                        {
                            MontoPagar[Nvehiculo] = peaje;
                            Pago[Nvehiculo] = efectivo;
                            Vuelto[Nvehiculo] = efectivo - peaje;
                        }
                        else
                        {
                            Console.WriteLine("Pago insuficiente, intente de nuevo");
                        }
                    } while (efectivo < (peaje - 1));
                    Console.WriteLine($"Su vuelto es de: {Vuelto[Nvehiculo]} colones");
                    Nvehiculo++;
                }
                else
                {
                    Console.WriteLine("Cantidad maxima de transacciones registrados");
                }
                Console.WriteLine("Desea continuar? \n(S/N)");
                string opcion = Console.ReadLine();
                if ((opcion.Equals("N")) || (opcion.Equals("n")))
                {
                    continuar = true;
                }

            } while (continuar == false);
        }

        public void Consulta()
        {
            Console.WriteLine("Digite el numero de placa a consultar");
            string placa = Console.ReadLine();
            bool existe = false;
            for (int i = 0; i < N; i++)
            {
                if (placa.Equals(NumeroPlaca[i]))
                {
                    Console.WriteLine($"Factura N#: {NumeroFactura[i]}");
                    Console.WriteLine($"Placa N#: {NumeroPlaca[i]}");
                    Console.WriteLine($"Fecha: {Fecha[i]}");
                    Console.WriteLine($"Hora: {Hora[i]}");
                    switch (TipoVehiculo[i])
                    {
                        case 1:
                            Console.WriteLine("Tipo de vehiculo: Moto");
                            break;
                        case 2:
                            Console.WriteLine("Tipo de vehiculo: Vehiculo Liviano");
                            break;
                        case 3:
                            Console.WriteLine("Tipo de vehiculo: Camion Pesado");
                            break;
                        case 4:
                            Console.WriteLine("Tipo de vehiculo: Autobus");
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine($"Caseta N#: {NumeroCaseta[i]}");
                    Console.WriteLine($"Monto a pagar: {MontoPagar[i]}");
                    Console.WriteLine($"Pago con: {Pago[i]}");
                    Console.WriteLine($"Vuelto: {Vuelto[i]}");
                    existe = true;
                }
            }
            if (!existe)
            {
                Console.WriteLine("No se encontro el registro");
            }
        }
        public void Modificar()
        {
            Console.WriteLine("Digite el numero de placa a Modificar");
            string placa = Console.ReadLine();
            bool existe = false;
            int Nvehiculo = 0;
            for (int i = 0; i < N; i++)
            {
                if (placa.Equals(NumeroPlaca[i]))
                {
                    Console.WriteLine($"Factura N#: {NumeroFactura[i]}");
                    Console.WriteLine($"Placa N#: {NumeroPlaca[i]}");
                    Console.WriteLine($"Fecha: {Fecha[i]}");
                    Console.WriteLine($"Hora: {Hora[i]}");
                    switch (TipoVehiculo[i])
                    {
                        case 1:
                            Console.WriteLine("Tipo de vehiculo: Moto");
                            break;
                        case 2:
                            Console.WriteLine("Tipo de vehiculo: Vehiculo Liviano");
                            break;
                        case 3:
                            Console.WriteLine("Tipo de vehiculo: Camion Pesado");
                            break;
                        case 4:
                            Console.WriteLine("Tipo de vehiculo: Autobus");
                            break;
                        default:
                            break;
                    }

                    Console.WriteLine($"Caseta N#: {NumeroCaseta[i]}");
                    Console.WriteLine($"Monto a pagar: {MontoPagar[i]}");
                    Console.WriteLine($"Pago con: {Pago[i]}");
                    Console.WriteLine($"Vuelto: {Vuelto[i]}");
                    existe = true;
                    Nvehiculo = i;
                }
            }
            if (!existe)
            {
                Console.WriteLine("No se encontro el registro");
            }
            if (existe == true)
            {
                do
                {
                    //Menu modificar
                    Console.WriteLine("Escriba la opcion que desea modificar: \n1-Numero Placa\n2-Fecha\n3-Hora\n4-Pago\n5-salir");
                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Escriba el nuevo numero de placa: ");
                            string numplaca = Console.ReadLine();
                            NumeroPlaca[Nvehiculo] = numplaca;
                            break;
                        case 2:
                            Console.WriteLine("Escriba la nueva fecha: ");
                            string fe = Console.ReadLine();
                            Fecha[Nvehiculo] = fe;
                            break;
                        case 3:
                            Console.WriteLine("Escriba la nueva hora: ");
                            string ho = Console.ReadLine();
                            Hora[Nvehiculo] = ho;
                            break;
                        case 4:

                            float efectivo;
                            float peaje = Costos[TipoVehiculo[Nvehiculo] - 1];

                            do

                            {
                                Console.WriteLine("Escriba el nuevo monto con el que pago: ");
                                efectivo = float.Parse(Console.ReadLine());

                                if (efectivo > (peaje - 1))
                                {
                                    MontoPagar[Nvehiculo] = peaje;
                                    Pago[Nvehiculo] = efectivo;
                                    Vuelto[Nvehiculo] = efectivo - peaje;
                                }
                                else
                                {
                                    Console.WriteLine("El monto que paga no puede ser menor al monto a pagar");
                                }
                            } while (efectivo < (peaje - 1));
                            Console.WriteLine($"El vuelto se actualizo a : {Vuelto[Nvehiculo]} colones");

                            break;
                        default:
                            break;
                    }

                } while (existe != true);
            }
        }

        public void Reporte()
        {
            Console.WriteLine("N# Factura   N# Placa    Fecha    Hora   Vehiculo   Caseta   Monto   Paga con   Vuelto");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            for (int i = 0; i < N; i++)
            {
                if (TipoVehiculo[i] > 0)
                {
                    Console.WriteLine($"{NumeroFactura[i]} / {NumeroPlaca[i]} / {Fecha[i]} / {Hora[i]} / {NumeroCaseta[i]} / {MontoPagar[i]} / {Pago[i]} / {Vuelto[i]}");
                    
                }

            }
            Console.WriteLine("---------------------------------------------------------------------------------------");
        }
    }
}
