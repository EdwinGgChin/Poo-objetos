using Objetos.Clases;
using System;

namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona(); //instanciar, crear un nuevo objeto real

            persona.Nombre = "Pedro";
            persona.Apellido = "Picapiedra";
            persona.Edad = 25;
            persona.Salario = 300.4554;

            persona.ImprimirDatos();

            Console.WriteLine("::::::::::::::::::::::::::::::::::");

            Persona persona2 = new Persona();
            Console.ForegroundColor = ConsoleColor.Yellow;
            persona2.Nombre = "Monica";
            persona2.Apellido = "Diaz";
            persona2.Edad = 19;
            persona2.Salario = 300.4554;

            persona2.ImprimirDatos();




        }
    }
}
