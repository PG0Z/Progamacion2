using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4progra2
{
    internal class Program
    {
        public class Vehiculo // se crea la clase
        {
            //Se crean los atributos de la clase(pueden ser publicos, privados o protegidos)
            public byte Ruedas;
            public byte Puertas;
            public string Marca;
            public int Modelo;

            public Vehiculo(byte rueda, byte puerta, string marca, int modelo) //se crea la funcion y se crean variables
            {
                // A los Atributos de la clase se les establece como valor la variable de la funcion
                Ruedas = rueda;
                Puertas = puerta;
                Marca = marca;
                Modelo = modelo;
            }
        }
        static void Main(string[] args)
        {
            //Clase Vehiculo
            Vehiculo Toyota = new Vehiculo(4, 4, "Toyota", 2015);//Se llama a la clase y se establecen los valores de las variables
            Console.WriteLine($"El vehiculo es un {Toyota.Marca} modelo {Toyota.Modelo} con {Toyota.Ruedas} ruedas y {Toyota.Puertas} puertas");

            Vehiculo Subaru = new Vehiculo(4, 2, "Subaru", 1995);//Se hace otro llamado a la misma clase pero con diferentes valores
            Console.WriteLine($"El impreza es marca {Subaru.Marca} de {Subaru.Modelo}, cuenta con {Subaru.Ruedas} ruedas y {Subaru.Puertas} puertas");


            /* Funciones para tipo texto
            string palabra = "Abecedario";
            Console.WriteLine("Largo de la palabra= "+palabra.Length);
            Console.WriteLine("Tomar la letra de cualquier posicion+ "+palabra[2]);
            Console.WriteLine("Averigua la posicion de cualquier palabra del texto= "+palabra.IndexOf("A"));
            Console.WriteLine("Empieza el texto a partir de la posicion= "+palabra.Substring(2));
            */


            //Clase Persona
            Persona persona1 = new Persona(); //LLamado a la clase
            persona1.SetNombre("Pablo");
            persona1.SetCedula("2-0844-0254");
            Console.WriteLine(persona1.GetNombre() + " / " + persona1.GetCedula());
            Persona persona2 = new Persona();
            persona2.SetNombre("Naruto");
            persona2.SetCedula("3-1111-2222");
            Console.WriteLine(persona2.GetNombre() + " / " + persona2.GetCedula());

            //Herencia
            Persona salario= new Persona();
            salario.Altura();




            //Metodos y Funciones
            /*
             * Program calculadora = new Program(); //Creacion una instancia
            calculadora.Suma(); //Llamado al metodo
            Console.WriteLine(calculadora.Resta()); //Llamado a la funcion
            //calculadora.Division(10, 5);//Llamado al metodo y al mismo tiempo se establece el valor de los parametros del metodo
            calculadora.Division(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));//Llamado a la funcion y al mismo tiempo se piden los datos dinamicos al usuario
            Console.WriteLine(calculadora.Multiplicacion());//Llamado a la funcion y se piden datos dinamicos
            */


            Console.Read();

        }


        public void Suma() //Creacion de un metodo(utiliza void)
        {
            Console.WriteLine(5 + 1);
        }
        public float Resta() //Creacion de una funcion(devuelve un valor con el return, no utiliza void)
        {
            Console.WriteLine("Esto es una resta");
            float total = 5 - 4;
            return total;
        }
        public void Division(float num1, float num2)//Creacion de un metodo con 2 parametros
        {
            Console.WriteLine($"Resultado de la division = {num1 / num2}");
        }
        public float Multiplicacion(float num1 = 0, float num2 = 0)
        {
            Console.WriteLine("Ingrese un numero");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            num2 = float.Parse(Console.ReadLine());
            float total = num1 * num2;
            return total;
        }

    }
}
