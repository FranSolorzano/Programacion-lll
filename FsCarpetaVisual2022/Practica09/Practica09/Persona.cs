using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica09
{
    internal class Persona
    {
        string nombres;
        string apellidos;
        string sexo;
        int edad;

        //4 miembros de clase que serian 4 atributos
        public void Caminar ()
        {
            Console.WriteLine(nombres + " " + apellidos + " camina con el culito parado");
        }

        public void capturarDatos()
        {
            Console.WriteLine("Por favor ingrese sus datos");
            Console.WriteLine("Ingrese su nombre: ");
            nombres = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            apellidos = Console.ReadLine();
            Console.WriteLine("Ingrese su sexo: ");
            sexo = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");                                 
            edad = Convert.ToInt32(Console.ReadLine());
        }

        public void mostrarDatos()
        {   Console.WriteLine($"Nombres: {nombres}");
            Console.WriteLine($"Apellidos: {apellidos}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Edad: {edad}");

            Persona per = new Persona();
            per.Caminar();
        }

       
    }
    class Empleado : Persona
    {
        string cargo = "Vendedor";
        string departamento = "Deportes";

        void mensaje()
        {
            Persona perso = new Persona();
            perso.capturarDatos();
        }
    }

}
