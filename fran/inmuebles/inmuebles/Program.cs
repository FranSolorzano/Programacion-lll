using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inmuebles
{

    //INTEGRANTES DEL EQUIPO: FRANKLIN NOE SOLORZANO ERAZO & LUIS ELIAN ARTEAGA DIAS
    internal class Program
    {

        public abstract class Inmueble
        {
            protected double precioVenta;
            protected double precio;
            protected string nombreProducto;
            protected string nombre;
            protected string apellido;
            protected string Contrato;
           
            
        }

        public class Cliente 
        {
            public Cliente(string name, string lastname)              
            {

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
        public string datos { get; set; }


    }

    class Cliente : Persona
    {


    }

    class Empleados : Persona
    {

    }

    class Inmuebles : Contrato
    {
        
    }

    class Contrato
    {
        public Contrato()
        {
        }

        public Contrato(string v)
        {
            V = v;
        }

        public string dias { get; set; }
        public string imprimirdatos { get; set; }
        public string V { get; }

        internal static bool imprimirDatos()
        {
            throw new NotImplementedException();
        }

    }
    class program1
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();

            Console.WriteLine("Por favor ingrese su nombre: ");
            persona.nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su apellido: ");
            persona.apellido = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su edad: ");
            persona.edad = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su direccion: ");
            persona.direccion = Console.ReadLine();
            Console.Clear();

            Empleados empleado1 = new Empleados();
            Empleados empleado2 = new Empleados();

            Contrato cantidad = new Contrato();

            int cantidad1;

            double saldo;

            




            Console.WriteLine("\nBIENVENIDO SEA A NUESTRA VENTA DE INMUEBLES " + " " + persona.nombre + " " + persona.apellido);
            int opcion;


            Console.WriteLine("********************************MENU DE INMUEBLES***********************************");
            Console.WriteLine("¿Que tipo de inmueble deseas adquirir?" + persona);
            Console.WriteLine("1-- CASA DE PLAYA");
            Console.WriteLine("2-- CASA DE ZONA URBANA");
            /*Console.WriteLine("3-- DEPARTAMENTO");
            Console.WriteLine("4-- PARCELAS");
            Console.WriteLine("5-- EDIFICIO");*/
            opcion = int.Parse(Console.ReadLine());

            Console.Clear();


            switch (opcion)
            {

                case 1:
                    int opc;
                    Console.WriteLine("\n¿Por cual empleado le gustaria ser atendido?");
                    Console.WriteLine("1)-- JOSE");
                    Console.WriteLine("2)-- CARLOS");
                    opc = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (opc)
                    {
                        case 1:
                            int opcioncasadeplaya;
                            Console.WriteLine("Estas siendo atendido por JOSE");
                            Console.WriteLine("----------CASA DE PLAYA----------");
                            Console.WriteLine("Por favor " + persona.nombre + " " + persona.apellido + " ingrese la cantidad de dias que desea adquirir el inmueble: ");
                            cantidad.dias = Console.ReadLine();
                            Console.WriteLine(cantidad.dias);
                            cantidad1 = int.Parse(Console.ReadLine());
                            int costo1 = 300;
                            costo1 = int.Parse(Console.ReadLine());
                            saldo = costo1 * cantidad1;
                            
                            Console.WriteLine("El saldo que tendra que pagar por los dias requeridos es de: " + saldo);
                            Console.Clear();



                            opcioncasadeplaya = int.Parse(Console.ReadLine());
                            switch (opcioncasadeplaya)
                            {
                                case 1:
                                    Contrato contrato = new Contrato(
                                        "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Suspendisse ut metus. Proin venenatis turpis " +
                                        "\nsit amet ante consequat semper. Aenean nunc. Duis iaculis odio id lectus. Integer dapibus justo vitae elit. Nunc luctus, " +
                                        "\ntortor quis iaculis tempus, urna odio iaculis erat, imperdiet lobortis orci lectus at eros");
                                    Console.WriteLine(Contrato.imprimirDatos());
                                    break;
                                case 2:
                                    Environment.Exit(0);
                                    break;


                            }
                            break;
                        case 2:
                            int opcioncasadeplaya1;
                            Console.WriteLine("Estas siendo atendido por CARLOS");
                            Console.WriteLine("----------CASA DE PLAYA----------");
                            Console.WriteLine("Por favor " + persona.nombre + " " + persona.apellido + " ingrese la cantidad de dias que desea adquirir el inmueble: ");
                            cantidad.dias = Console.ReadLine();
                            Console.WriteLine(cantidad);
                            cantidad1 = int.Parse(Console.ReadLine());
                            int costo2 = 300;
                            costo1 = int.Parse(Console.ReadLine());
                            saldo = costo2 * cantidad1;
                            Console.WriteLine("El saldo que tendra que pagar por los dias requeridos es de: " + saldo);
                            Console.Clear();

                            opcioncasadeplaya1 = int.Parse(Console.ReadLine());
                            switch (opcioncasadeplaya1)
                            {
                                case 1:
                                    Contrato contrato = new Contrato(
                                            "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Suspendisse ut metus. Proin venenatis turpis " +
                                            "\nsit amet ante consequat semper. Aenean nunc. Duis iaculis odio id lectus. Integer dapibus justo vitae elit. Nunc luctus, " +
                                            "\ntortor quis iaculis tempus, urna odio iaculis erat, imperdiet lobortis orci lectus at eros");
                                    Console.WriteLine(contrato);
                                    break;
                                case 2:
                                    Environment.Exit(0);
                                    break;


                            }
                            break;


                    }
                    break;
                case 2:
                    int opcion2;
                    Console.WriteLine("¿Quien quieres que te atienda? ");
                    Console.WriteLine("1- JOSE");
                    Console.WriteLine("2- CARLOS");
                    opcion2 = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (opcion2)
                    {
                        case 1:
                            int opcioncasaurbana;
                            Console.WriteLine("Estas siendo atendido por JOSE");
                            Console.WriteLine("----------CASA URBANA----------");
                            Console.WriteLine("Por favor " + persona.nombre + " " + persona.apellido + " ingrese la cantidad de dias que desea adquirir el inmueble: ");
                            cantidad.dias = Console.ReadLine();
                            Console.WriteLine(cantidad);
                            cantidad1 = int.Parse(Console.ReadLine());
                            int costo1 = 300;
                            costo1 = int.Parse(Console.ReadLine());
                            saldo = costo1 * cantidad1;
                            Console.WriteLine("El saldo que tendra que pagar por los dias requeridos es de: " + saldo);
                            Console.Clear();

                            opcioncasaurbana = int.Parse(Console.ReadLine());
                            switch (opcioncasaurbana)
                            {
                                case 1:
                                    Contrato contrato = new Contrato(
                                            "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Suspendisse ut metus. Proin venenatis turpis " +
                                            "\nsit amet ante consequat semper. Aenean nunc. Duis iaculis odio id lectus. Integer dapibus justo vitae elit. Nunc luctus, " +
                                            "\ntortor quis iaculis tempus, urna odio iaculis erat, imperdiet lobortis orci lectus at eros");
                                    Console.WriteLine(contrato);
                                    break;
                                case 2:
                                    Environment.Exit(0);
                                    break;


                            }
                            break;
                        case 2:
                            int opcioncasaurbana1;
                            Console.WriteLine("Estas siendo atendido por CARLOS");
                            Console.WriteLine("----------CASA URBANA----------");
                            Console.WriteLine("Por favor " + persona.nombre + " " + persona.apellido + " ingrese la cantidad de dias que desea adquirir el inmueble: ");
                            cantidad.dias = Console.ReadLine();
                            Console.WriteLine(cantidad);
                            cantidad1 = int.Parse(Console.ReadLine());
                            int costo2 = 300;
                            costo1 = int.Parse(Console.ReadLine());
                            saldo = costo2 * cantidad1;
                            Console.WriteLine("El saldo que tendra que pagar por los dias requeridos es de: " + saldo);
                            Console.Clear();

                            opcioncasaurbana1 = int.Parse(Console.ReadLine());
                            switch (opcioncasaurbana1)
                            {
                                case 1:
                                    Contrato contrato = new Contrato(
                                            "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Suspendisse ut metus. Proin venenatis turpis " +
                                            "\nsit amet ante consequat semper. Aenean nunc. Duis iaculis odio id lectus. Integer dapibus justo vitae elit. Nunc luctus, " +
                                            "\ntortor quis iaculis tempus, urna odio iaculis erat, imperdiet lobortis orci lectus at eros");

                                    Console.WriteLine(contrato);
                                    break;
                                case 2:
                                    Environment.Exit(0);
                                    break;


                            }
                            break;


                    }
                    break;
            }


        }
    }
    

    


}

        
            
    
     




