using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inmuebles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            Console.WriteLine("Por favor ingrese su nombre");
            persona.nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su apellido");
            persona.apellido = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("\nBIENVENIDO SEA A NUESTRA VENTA DE INMUEBLES " + " " + persona.nombre + " "+persona.apellido);
            int opcion;

            Console.WriteLine("********************************MENU DE INMUEBLES***********************************");
            Console.WriteLine("¿Que tipo de inmueble deseas adquirir?" + persona);
            Console.WriteLine("1-- CASA DE PLAYA");
            Console.WriteLine("2-- DEPARTAMENTO");
            Console.WriteLine("3-- PARECELAS");
            Console.WriteLine("4-- EDIFICIO");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Clear();
                    
                    Console.WriteLine("Casa de playa");
                    break;
            }
            
        }
        
            
    }

     class Persona
    {
        public string id { get; set; }
        public string dui { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string edad { get; set; }
        public string direccion { get; set; }


    }

    class Cliente : Persona 
    {
        public int NumTelefonico;
        
    }   

    class Empleados :Persona
    {

    }

    class Inmuebles
    {

    }

    class Contrato
    {

    }
}
