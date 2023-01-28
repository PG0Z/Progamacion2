using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Clase2Progra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tipos de datos C#

            int num1 = 0;
            int num2 = 5, num3 = 6;
            int total = new int();

            bool booleana = new bool();

            uint positivo1 = 0;
            long largos = 29184874871;
            ulong ularga = 2222;
            byte b = 255;
            sbyte s = -1;
            float flotante = 29.999f;
            double doble = 100.5d;
            decimal decim = 3.141618m;
            bool booleano = false;
            char caracter = 'a';
            string nombre = "Pablo";
            String apellido = "Gonzalez";

            Console.WriteLine("total: " + total + "\nBooleano: " + booleana);

            //Desplegar con parametros

            Console.WriteLine("La persona se llama {0}{1}", nombre, apellido);

            //Desplegar con interpolaion "$"

            Console.WriteLine($"La persona se llama {nombre} {apellido}");

            //Var y dynamic


            var persona = new { NOMBRE = "PGOZ", TAG = "#777", EDAD = 12 };

            Console.WriteLine($"{persona.NOMBRE}{persona.TAG}{persona.EDAD}");

            // Pedir datos, leer, etc...
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite el salario por hora");
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite las horas trabajadas");
            int horas = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("La persona {0} {1} recibe un salario de:  {2}", nombre, apellido, salario*horas);

            //Contadores y acumuladores
           int suma = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Digite un numero");
                int n1 = Convert.ToInt32(Console.ReadLine());
                suma += n1; //suma = suma+n1, esto funciona con cualquier operador
            }

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("La suma de los valores da como resultado {0}",suma);

            //Arreglos y matrices

            int[] rating = new int[] {10,9,8,7};//arreglo n posiciones
            String[] animes = new String[4];
            animes[0] = "One Piece";
            animes[1] = "DBZ";
            animes[2] = "Bleach";
            animes[3] = "Naruto";

            //ciclos 
            for (int i = 0;i < animes.Length; i++)
            {
                Console.ForegroundColor =ConsoleColor.Gray;
                Console.WriteLine($"El anime top {i+1}: {animes[i]} // Rating: {rating[i]}");
            }
                

            Console.ReadLine();

        }
    }
}
namespace espaciodememoria
{

    //Se usa para crear un nuevo espacio de memoria y asi una clase nueva
    public class clasenueva
    {
    }

}
