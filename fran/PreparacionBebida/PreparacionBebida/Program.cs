using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//el cliente debe de ser mayor de edad para las bebidas frias


public interface IDatos
{
    string DatosPersonales();
    string Caracteristicas();
}


public abstract class Datos
{
    public string nombre{ get; set; }
    public string apellido{ get; set; }
    public string telefono{ get; set; }
    public string direccion{ get; set; }
    public string tipoBebida{ get; set; }  //jugos, cafe
    public string categoria{ get; set; }   //alcoholicas y no
    public int edad{ get; set; }   //si es mayor o no
    public string descripcion{ get; set; }   //como el cliente se lo pide
    public string receta{ get; set; }   //preparacion
    

    public abstract string Caracteristicas();
}

public class Cliente : Datos, IDatos
{
    public Cliente(string Nombre, string Apellido, int Edad, string Telefono, string Direccion)
    {
        this.nombre = Nombre;
        this.apellido = Apellido;
        this.edad = Edad;
        this.telefono = Telefono;
        this.direccion = Direccion;
    }

    public string DatosPersonales()
    {

        /*Console.WriteLine("Por favor ingrese su nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Por favor ingrese su apellido: ");
        string apellido = Console.ReadLine();
        Console.WriteLine("Por favor ingrese su edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Por favor ingrese su numero telefonico");
        string telefono = Console.ReadLine();
        Console.WriteLine("Por favor ingrese su direccion: ");
        string direccion = Console.ReadLine();
        Console.Clear();
        string cliente = Convert.ToString(Console.ReadLine() + (nombre, apellido, edad, telefono, direccion));
        Cliente cliente = new Cliente(nombre, apellido, edad, telefono, direccion);        
        return cliente;*/
       
        
        string adios = "E3l empleado : " + this.nombre + " se despide cordealmente";
        return adios;
        

    }

    public override string Caracteristicas()
    {
        string saludo = "Hola mi nombre es: " + this.nombre + " y soy un alumno";
        return saludo;
    }
}







namespace PreparacionBebida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datos del cliente   
            Console.WriteLine("Por favor ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su edad: ");
            int edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Por favor ingrese su numero telefonico");
            string telefono = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su direccion: ");
            string direccion = Console.ReadLine();
            Console.Clear();

            Cliente cliente = new Cliente(nombre, apellido, edad, telefono, direccion);


            //preguntarle al cliente como quiere su bebida y que bebida quiere

            Console.WriteLine("****************BIENVENIDOS A MAREADAS DRINK****************");
            Console.WriteLine("\n");
            int opcion;

            Console.WriteLine("------JUGOS NATURALES------");
            Console.WriteLine("1--JUGO DE NARANJA");
            Console.WriteLine("2--JUGO DE MANZANA");
            Console.WriteLine("3--JUGO DE PERA");
            Console.WriteLine("4--JUGO DE PIÑA");
            Console.WriteLine("\t");
            Console.WriteLine("------LICUADOS------");
            Console.WriteLine("5--LICUADO DE FRESA");
            Console.WriteLine("6--LICUADO DE GUINEO");
            Console.WriteLine("7--LICUADO DE UVA");
            Console.WriteLine("8--LICUADO DE PAPAYA");
            Console.WriteLine("\t");
            Console.WriteLine("------TE------");
            Console.WriteLine("9--TE DE LIMON");
            Console.WriteLine("10--TE DE DURAZNO");
            Console.WriteLine("11--TE DE JAMAICA");
            Console.WriteLine("12--TE DE APIO");
            Console.WriteLine("\t");
            Console.WriteLine("------BEBIDAS CALIENTES------");
            Console.WriteLine("13--CAFE");
            Console.WriteLine("14--CHOCOLATE");
            Console.WriteLine("15--CAPUCCINO");
            Console.WriteLine("16--ATOL DE ALMENDRA");
            Console.WriteLine("\t");
            Console.WriteLine("------BEBIDAS FRIAS------");
            Console.WriteLine("17--CERVEZAS");
            Console.WriteLine("18--SODAS");
            Console.WriteLine("19--JOSE CUERVO");
            Console.WriteLine("20--JACK DANIEL´S");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.ReadLine();


            switch (opcion)
            {
                case 1:
                    int opc;
                    Console.WriteLine("\n¿Por cual empleado le gustaria ser atendido?");
                    Console.WriteLine("1)-- JOSE CASTILLO");
                    Console.WriteLine("2)-- CARLOS PEREZ");
                    opc = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (opc)
                    {
                        case 1:
                            int opcionjugonaranja;
                            Console.WriteLine("Estas siendo atendido por JOSE CASTILLO");
                            Console.WriteLine("----------CASA DE PLAYA----------");
                            Console.WriteLine("Por favor " + cliente.nombre + " " + cliente.apellido + " ingrese la cantidad de dias que desea adquirir el inmueble: ");
                            cantidad.dias = Console.ReadLine();
                            Console.WriteLine("Tus dias son: " + cantidad.dias);
                            int costo1 = 300;
                            Console.WriteLine("El costo que tendra que pagar por los dias requeridos es de: " + costo1 * int.Parse(cantidad.dias));
                            Console.Clear();
                            Console.WriteLine("**************SU CONTRATO CONTIENE LOS DATOS DE ACUERDOS SIGUIENTES**************");
                            Console.WriteLine("___DATOS PERSONALES___");
                            Console.WriteLine("---El vendedor JOSE CASTILLO da en arrendamiento a: " + persona.nombre + " " + persona.apellido);
                            Console.WriteLine("---Que cuenta con el numero de identificacion personal: " + persona.dui);
                            Console.WriteLine("---Con " + persona.edad + " años de edad");
                            Console.WriteLine("---Quien reside en: " + persona.direccion);
                            Console.WriteLine("---De numero telefonico: " + persona.telefono);
                            Console.WriteLine("___DATOS DEL INMUEBLE___");
                            Console.WriteLine("---El inmueble: CASA DE PLAYA " + "con un costo de: " + costo1 * int.Parse(cantidad.dias) + " dolares, por su adquisicion de: " + cantidad.dias + " dias, ubicada a un costado de LA PLAYA EL SOL");

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
                            Console.WriteLine("Estas siendo atendido por CARLOS PEREZ");
                            Console.WriteLine("----------CASA DE PLAYA----------");
                            Console.WriteLine("Por favor " + persona.nombre + " " + persona.apellido + " ingrese la cantidad de dias que desea adquirir el inmueble: ");
                            cantidad.dias = Console.ReadLine();
                            Console.WriteLine("Tus dias son: " + cantidad.dias);
                            int costo2 = 300;
                            Console.WriteLine("El costo que tendra que pagar por los dias requeridos es de: " + costo2 * int.Parse(cantidad.dias));
                            Console.Clear();
                            Console.WriteLine("**************SU CONTRATO CONTIENE LOS DATOS DE ACUERDOS SIGUIENTES**************");
                            Console.WriteLine("___DATOS PERSONALES___");
                            Console.WriteLine("---El vendedor CARLOS PEREZ da en arrendamiento a: " + persona.nombre + " " + persona.apellido);
                            Console.WriteLine("---Que cuenta con el numero de identificacion personal: " + persona.dui);
                            Console.WriteLine("---Con " + persona.edad + " años de edad");
                            Console.WriteLine("---Quien reside en: " + persona.direccion);
                            Console.WriteLine("---De numero telefonico: " + persona.telefono);
                            Console.WriteLine("___DATOS DEL INMUEBLE___");
                            Console.WriteLine("---El inmueble: CASA DE PLAYA " + "con un costo de: " + costo2 * int.Parse(cantidad.dias) + " dolares, por su adquisicion de: " + cantidad.dias + " dias, ubicada a un costado de LA PLAYA EL SOL ");

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
                    Console.WriteLine("¿Por cual empleado le gustaria ser atendido ? ");
                    Console.WriteLine("1- JOSE");
                    Console.WriteLine("2- CARLOS");
                    opcion2 = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (opcion2)
                    {
                        case 1:
                            int opcioncasaurbana;
                            Console.WriteLine("Estas siendo atendido por JOSE CASTILLO");
                            Console.WriteLine("----------CASA URBANA----------");
                            Console.WriteLine("Por favor " + persona.nombre + " " + persona.apellido + " ingrese la cantidad de dias que desea adquirir el inmueble: ");
                            cantidad.dias = Console.ReadLine();
                            Console.WriteLine("Tus dias son: " + cantidad.dias);
                            int costo2 = 250;
                            Console.WriteLine("El costo que tendra que pagar por los dias requeridos es de: " + costo2 * int.Parse(cantidad.dias));
                            Console.Clear();
                            Console.WriteLine("**************SU CONTRATO CONTIENE LOS DATOS DE ACUERDOS SIGUIENTES**************");
                            Console.WriteLine("___DATOS PERSONALES___");
                            Console.WriteLine("---El vendedor JOSE CASTILLO da en arrendamiento a: " + persona.nombre + " " + persona.apellido);
                            Console.WriteLine("---Que cuenta con el numero de identificacion personal: " + persona.dui);
                            Console.WriteLine("---Con " + persona.edad + " años de edad");
                            Console.WriteLine("---Quien reside en: " + persona.direccion);
                            Console.WriteLine("---De numero telefonico: " + persona.telefono);
                            Console.WriteLine("___DATOS DEL INMUEBLE___");
                            Console.WriteLine("---El inmueble: CASA URBANA " + "con un costo de: " + costo2 * int.Parse(cantidad.dias) + " dolares, por su adquisicion de: " + cantidad.dias + " dias, ubicada en Colonia Colorado");

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
                            Console.WriteLine("Estas siendo atendido por CARLOS PEREZ");
                            Console.WriteLine("----------CASA URBANA----------");
                            Console.WriteLine("Por favor " + persona.nombre + " " + persona.apellido + " ingrese la cantidad de dias que desea adquirir el inmueble: ");
                            cantidad.dias = Console.ReadLine();
                            Console.WriteLine("Tus dias son: " + cantidad.dias);
                            int costo3 = 250;
                            Console.WriteLine("El costo que tendra que pagar por los dias requeridos es de: " + costo3 * int.Parse(cantidad.dias));
                            Console.Clear();
                            Console.WriteLine("**************SU CONTRATO CONTIENE LOS DATOS DE ACUERDOS SIGUIENTES**************");
                            Console.WriteLine("___DATOS PERSONALES___");
                            Console.WriteLine("---El vendedor CARLOS PEREZ da en arrendamiento a: " + persona.nombre + " " + persona.apellido);
                            Console.WriteLine("---Que cuenta con el numero de identificacion personal: " + persona.dui);
                            Console.WriteLine("---Con " + persona.edad + " años de edad");
                            Console.WriteLine("---Quien reside en: " + persona.direccion);
                            Console.WriteLine("---De numero telefonico: " + persona.telefono);
                            Console.WriteLine("___DATOS DEL INMUEBLE___");
                            Console.WriteLine("---El inmueble: CASA URBANA " + "con un costo de: " + costo3 * int.Parse(cantidad.dias) + " dolares, por su adquisicion de: " + cantidad.dias + " dias, ubicada en Colonia Colorado");

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
