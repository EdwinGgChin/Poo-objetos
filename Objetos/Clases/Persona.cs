using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Clases
{
    //clases es uma plantilla que contiene objetos y metodos 
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public double Salario { get; set; }

        public void ImprimirDatos()
        {
            Console.WriteLine("Tu nombre es:" + this.Nombre);
            Console.WriteLine("Tu apellido es:" + this.Apellido);
            Console.WriteLine("Tu Edad es:" + this.Edad);
            Console.WriteLine("Tu Salario es:" + this.Salario);

           
        }
    }
}
