using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Proyecto1ProgramacionII.Program;

namespace Proyecto1ProgramacionII
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Mostrar();
        }

        class Menu
        {
            Articulos articulo;
            Vendedor vendedor;
            Categoria categoria;

            public Menu()
            {
                articulo = new Articulos();
                vendedor = new Vendedor();
                categoria = new Categoria();
            }

            public void Mostrar()
            {
                string opcion = "";

                do
                {
                    Console.Clear();
                    Console.WriteLine("Menú principal");
                    Console.WriteLine("a. Artículos");
                    Console.WriteLine("b. Facturación");
                    Console.WriteLine("c. Reporte");
                    Console.WriteLine("d. Salir");
                    Console.Write("Seleccione una opción: ");
                    opcion = Console.ReadLine().ToLower();

                    switch (opcion)
                    {
                        case "a":
                            MenuArticulos();
                            break;
                        case "b":
                            Facturacion();
                            break;
                        case "c":
                            Reporte();
                            break;
                        case "d":
                            Console.WriteLine("Hasta pronto!");
                            break;
                        default:
                            Console.WriteLine("Opción inválida");
                            break;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();

                } while (opcion != "d");


            }

            private void MenuArticulos()
            {
                string opcion = "";

                do
                {
                    Console.Clear();
                    Console.WriteLine("Menú de Artículos");
                    Console.WriteLine("a. Agregar");
                    Console.WriteLine("b. Consultar");
                    Console.WriteLine("c. Borrar");
                    Console.WriteLine("d. Volver");
                    Console.Write("Seleccione una opción: ");
                    opcion = Console.ReadLine().ToLower();

                    switch (opcion)
                    {
                        case "a":
                            articulo.AgregarArticulo();
                            break;
                        case "b":
                            articulo.ConsultarArticulo();
                            break;
                        case "c":
                            articulo.BorrarArticulo();
                            break;
                        case "d":
                            Console.WriteLine("Volviendo al Menú principal...");
                            break;
                        default:
                            Console.WriteLine("Opción inválida");
                            break;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();

                } while (opcion != "d");
            }
            public void Facturacion()
            {
                // codigo Facturacion.
                Console.Clear();
                Articulos A = new Articulos();
                bool encontrado = false;
                bool existecategoria = false;
                bool vendedorexiste = false;
                Console.WriteLine("Favor Escriba el Codigo del Articulo a Facturar: ");
                string codigo = Console.ReadLine().ToLower();
                for (int i = 0; i < 5; i++)
                {
                    if (codigo.Equals(this.articulo.Codigo[i]))
                    {
                        encontrado = true;
                        do
                        {
                           
                            Console.Clear(); 
                            Console.WriteLine("*****Articulo*****");
                            Console.WriteLine($"Codigo: {this.articulo.Codigo[i]}");
                            Console.WriteLine($"Nombre: {this.articulo.Nombre[i]}");
                            Console.WriteLine($"Precio: {this.articulo.Precio[i]}");

                            Console.WriteLine("*****Categorias*****");
                            Categoria C = new Categoria();
                            ListadoCategorias();
                            C.Promocion();
                            Console.WriteLine("Porfavor digite el numero de categoria: ");
                            int opcion = int.Parse(Console.ReadLine());

                            if (opcion == 1)
                            {
                                Categoria1 C1 = new Categoria1();
                                C1.Promocion();
                                existecategoria = true;
                            }
                            else if (opcion == 2)
                            {
                                Categoria2 C2 = new Categoria2();
                                C2.Promocion();
                                existecategoria = true;
                            }
                            else if (opcion == 3)
                            {
                                Categoria3 C3 = new Categoria3();
                                C3.Promocion();
                                existecategoria = true;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("No se encontro la categoria, favor intente de nuevo:");
                                Console.ReadKey();
                            }
                        } while (!existecategoria);

                        Console.WriteLine("*****Lista de Vendedores***** ");
                        vendedor.ListadoVendedores();
                        Console.WriteLine("Escoja uno de los vendedores: ");
                      string ven=Console.ReadLine();
                        Vendedor V = new Vendedor();
                        V.VerificarVendedor(ven);


                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("No se encontró el articulo con el codigo ingresado");
                }
            }


            private void Reporte()
            {
                // codigo reporte.
                Console.Clear();
                Console.WriteLine("******Lista Vendedores*****");
                vendedor.ListadoVendedores();
                Console.WriteLine("*****Reporte Vendedores*****");
                vendedor.ReporteVendedores();
                Console.WriteLine("*****Articulos*****");
                articulo.ListadoArticulos();
                Console.WriteLine("*****Categorias*****");
                ListadoCategorias();
            }

            //----------------- Clase Articulos, con sus respectivos atributos ------------------------------

            public class Articulos
            {
                string[] codigo = new string[5];
                string[] nombre = new string[5];
                double[] precio = new double[5];
                Articulos[] articulos = new Articulos[5];
                int numArticulos = 0;

                public Articulos(string[] codigo, string[] nombre, double[] precio, int numArticulos)
                {
                    if (codigo.Length <= 5 && nombre.Length <= 5 && precio.Length <= 5)
                    {
                        this.codigo = codigo;
                        this.nombre = nombre;
                        this.precio = precio;
                        this.numArticulos = codigo.Length;
                    }
                    else
                    {
                        Console.WriteLine("No se pueden ingresar más de 5 artículos");
                    }
                }

                public Articulos() { }
                public int NumArticulos
                {
                    get { return numArticulos; }
                    set { numArticulos = value; }
                }
                public string[] Codigo
                {
                    get { return codigo; }
                    set { codigo = value; }
                }

                public string[] Nombre
                {
                    get { return nombre; }
                    set { nombre = value; }
                }

                public double[] Precio
                {
                    get { return precio; }
                    set { precio = value; }
                }

                public void AgregarArticulo()
                {
                    if (numArticulos < 5)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Ingresando Articulo No." + (numArticulos + 1));
                        Console.Write("Ingrese el codigo del articulo: ");
                        codigo[numArticulos] = Console.ReadLine();
                        Console.Write("Ingrese el nombre del articulo: ");
                        nombre[numArticulos] = Console.ReadLine();
                        Console.Write("Ingrese el precio del articulo: ");
                        precio[numArticulos] = double.Parse(Console.ReadLine());

                        articulos[numArticulos] = new Articulos
                        {
                            codigo = codigo,
                            nombre = nombre,
                            precio = precio
                        };

                        numArticulos++;

                        Console.WriteLine("Articulo ingresado correctamente!");
                    }
                    else
                    {
                        Console.WriteLine("No es posible ingresar mas articulos, capacidad maxima alcanzada.");
                    }
                }

                public void ConsultarArticulo()
                {
                    bool encontrado = false;
                    if (numArticulos == 0)
                    {
                        Console.WriteLine("No hay articulos ingresados");
                        return;
                    }
                    else
                    {

                        Console.WriteLine("Ingrese el codigo del articulo que desea consultar: ");
                        string codigo = Console.ReadLine();


                        for (int i = 0; i < numArticulos; i++)
                        {
                            if (codigo.Equals(this.codigo[i]))
                            {
                                Console.WriteLine("Articulo encontrado: ");
                                Console.WriteLine("Codigo: " + this.codigo[i]);
                                Console.WriteLine("Nombre: " + nombre[i]);
                                Console.WriteLine("Precio: " + precio[i]);
                                encontrado = true;
                                break;
                            }
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("No se encontró el articulo con el codigo ingresado");
                    }
                }
                public void ListadoArticulos()
                {
                    if (numArticulos == 0)
                    {
                        Console.WriteLine("No hay articulos");
                    }
                    else
                    {
                        for (int i = 0; i < numArticulos; i++)
                        {
                            Console.WriteLine($"{i + 1}. Codigo: {codigo[i]} - Nombre: {nombre[i]} - Precio: {precio[i]}");
                        }
                    }
                }

                        public void BorrarArticulo()
                {
                    if (numArticulos == 0)
                    {
                        Console.WriteLine("No hay articulos para borrar.");
                    }
                    else
                    {
                        Console.WriteLine("Listado de articulos:");
                        for (int i = 0; i < numArticulos; i++)
                        {
                            Console.WriteLine($"{i + 1}. Codigo: {codigo[i]} - Nombre: {nombre[i]} - Precio: {precio[i]}");
                        }

                        Console.Write("Seleccione el articulo que desea borrar: ");
                        int opcion = int.Parse(Console.ReadLine());

                        if (opcion < 1 || opcion > numArticulos)
                        {
                            Console.WriteLine("Opcion invalida.");
                        }
                        else
                        {
                            for (int i = opcion - 1; i < numArticulos - 1; i++)
                            {
                                codigo[i] = codigo[i + 1];
                                nombre[i] = nombre[i + 1];
                                precio[i] = precio[i + 1];
                                articulos[i] = articulos[i + 1];
                            }

                            codigo[numArticulos - 1] = null;
                            nombre[numArticulos - 1] = null;
                            precio[numArticulos - 1] = 0;
                            articulos[numArticulos - 1] = null;

                            numArticulos--;

                            Console.WriteLine("Articulo borrado correctamente.");
                        }
                    }
                }
               
            }// Fin de clase Articulos

            //----------------- Clases Categorias -1,2, con sus respectivos atributos ------------------------------
            public class Categoria
            {
                public int Numero { get; set; }
                public virtual void Promocion()
                {
                    Console.WriteLine("Descuentos y promociones");
                }
            }// Fin de clase Categoria

            public class Categoria1 : Categoria
            {
                public override void Promocion()
                {
                    Console.WriteLine("Descuento de 15%");
                }
            }// Fin de clase Categoria1

            public class Categoria2 : Categoria
            {
                public override void Promocion()
                {
                    Console.WriteLine("Promoción dos por uno");
                }
            }// Fin de clase Categoria2

            public class Categoria3 : Categoria
            {
                public override void Promocion()
                {
                    Console.WriteLine("Todo a mitad de precio");
                }
            }// Fin de clase Categoria3
            public static void ListadoCategorias()
            {
                Console.WriteLine("Categoria 1: 15% Descuento");
                Console.WriteLine("Categoria 2: Promocion dos por uno");
                Console.WriteLine("Categoria 3: Todo a mitad de precio");
            }

            // Fin de clases de categorias--------------------------------------------------------------------

            //----------------- Clases de vendedores, con sus respectivos atributos --------------------------
            public class Interfaces
            {
            }

            // Definir las interfaces
            public interface IVendedor1
            {
                void VentasContado(double monto);
            }

            public interface IVendedor2
            {
                string VentasCredito(double monto);
            }

            // Definir las clases de vendedor
            public class Vendedor1 : IVendedor1
            {
                public string Nombre { get; }

                public Vendedor1(string nombre)
                {
                    Nombre = nombre;
                }

                public void VentasContado(double monto)
                {
                    // Registrar la venta
                    Vendedor.RegistrarVentaContado(Nombre, monto);
                }
            }

            public class Vendedor2 : IVendedor2
            {
                public string Nombre { get; }

                public Vendedor2(string nombre)
                {
                    Nombre = nombre;
                }

                public string VentasCredito(double monto)
                {
                    // Registrar la venta
                    Vendedor.RegistrarVentaCredito(Nombre, monto);

                    return $"Venta a crédito de {monto} registrada para el vendedor {Nombre}.";
                }
            }

            // Definir la clase vendedor que maneja los vendedores y sus ventas
            public class Vendedor
            {
                private static Dictionary<string, string> vendedores = new Dictionary<string, string>() {
                    {"1","Vendedor 1"},
                    {"2","Vendedor 2" } };
                private static Dictionary<string, double> ventasContado = new Dictionary<string, double>(){
                    {"1", 1000000f},
                    {"2",2000000f}};
                private static Dictionary<string, double> ventasCredito = new Dictionary<string, double>() {
                    {"1", 3500000f},
                    {"2",2500000f } };

                public static void RegistrarVentaContado(string vendedor, double monto)
                {
                    // Verificar si el vendedor existe en el diccionario
                    if (vendedores.ContainsKey(vendedor))
                    {
                        // Si existe, registrar la venta
                        if (ventasContado.ContainsKey(vendedor))
                        {
                            ventasContado[vendedor] += monto;
                        }
                        else
                        {
                            ventasContado.Add(vendedor, monto);
                        }
                    }
                }
                public void VerificarVendedor(string vendedor)
                {
                    // Verificar si el vendedor existe en el diccionario
                    if (vendedores.ContainsKey(vendedor))
                    {
                        Console.WriteLine("Vendedor Existe");
                    }
                    else { Console.WriteLine("Vendedor no Existe"); }
                }

                        public static void RegistrarVentaCredito(string vendedor, double monto)
                {
                    // Verificar si el vendedor existe en el diccionario
                    if (vendedores.ContainsKey(vendedor))
                    {
                        // Si existe, registrar la venta
                        if (ventasCredito.ContainsKey(vendedor))
                        {
                            ventasCredito[vendedor] += monto;
                        }
                        else
                        {
                            ventasCredito.Add(vendedor, monto);
                        }
                    }
                }

                public void ListadoVendedores()
                {
                    foreach (KeyValuePair<string, string> Ven in vendedores)
                    {
                        Console.WriteLine("Vendedor: {0},Nombre: {1}", Ven.Key, Ven.Value);
                    }

                }
                public void ReporteVendedores()
                {
                    Console.WriteLine("Ventas Contado:");
                    foreach (KeyValuePair<string, double> Cont in ventasContado)
                    {
                        Console.WriteLine("Vendedor: {0},Total: {1}", Cont.Key, Cont.Value);
                    }
                    Console.WriteLine("Ventas Credito:");
                    foreach (KeyValuePair<string, double> Cred in ventasCredito)
                    {
                        Console.WriteLine("Vendedor: {0},Total: {1}", Cred.Key, Cred.Value);
                    }
                }

                public static string ObtenerNombreVendedor(string codigo)
                {
                    if (vendedores.ContainsKey(codigo))
                    {
                        return vendedores[codigo];
                    }
                    else
                    {
                        return "El vendedor con código " + codigo + " no existe.";
                    }
                }

                public static void AgregarVentaContado(string vendedor, double monto)
                {
                    if (ventasContado.ContainsKey(vendedor))
                    {
                        ventasContado[vendedor] += monto;
                    }
                    else
                    {
                        ventasContado.Add(vendedor, monto);
                    }
                }

                public static string AgregarVentaCredito(string vendedor, double monto)
                {
                    if (ventasCredito.ContainsKey(vendedor))
                    {
                        ventasCredito[vendedor] += monto;
                    }
                    else
                    {
                        ventasCredito.Add(vendedor, monto);
                    }

                    return "Venta a crédito agregada correctamente para " + vendedor;
                }

                public static double ObtenerVentasContado(string vendedor)
                {
                    if (ventasContado.ContainsKey(vendedor))
                    {
                        return ventasContado[vendedor];
                    }
                    else
                    {
                        return 0;
                    }
                }

                public static double ObtenerVentasCredito(string vendedor)
                {
                    if (ventasCredito.ContainsKey(vendedor))
                    {
                        return ventasCredito[vendedor];
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}