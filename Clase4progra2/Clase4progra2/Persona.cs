using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clase4progra2
{
    internal class Persona
    {
        //Crecion de Atributos


        public string Nombre { get; set; }//Se hace con "prop" + TAB
        public string Cedula { get; set; }

       
       
        //Creacion de polimorfismo, se utiliza el mismo metodo pero con diferentes resultados
        public virtual void Altura()
        {
            Console.WriteLine("La pesona es estatura media");
        }
        class Alto : Persona
        {
            public override void Altura()
            {
                Console.WriteLine("La persona es alta");
            }

        }
        class Bajo : Persona
        {
            public override void Altura()
            {
                Console.WriteLine("La persona es baja");
            }

        }






        //Herencia, se realiza con ":" aqui la clase Empleado hereda la clase Persona
        class Empleado : Persona
        {
            public void Salario()
            {
                int horas = 12;
                int pago = 2000;
                int salario = pago * horas;
                Console.WriteLine("El salario es de: " + salario);
            }
        }

        //Tambien se puede utilizar "propfull" + TAB


        //Constructor, sirve para inicializar los atributos de la clase
        public Persona()
        {
            Nombre = "Pato";
            Cedula = "1-1111-1111";
        }

        //Getter es para mostrar el valor de una variable o atributo

        public string GetNombre() { return "La persona se llama: " + Nombre; } //Es una funcion para ver el nombre
        public string GetCedula() { return "La Cedula es: " + Cedula; }

        //Setter es para asignar un valor al 

        public void SetNombre(string nombre) //Es un metodo para asignar un valor al nombre
        {
            Nombre = nombre;
        }
        public void SetCedula(string cedula)
        {
            Cedula = cedula;
        }
    }
}

