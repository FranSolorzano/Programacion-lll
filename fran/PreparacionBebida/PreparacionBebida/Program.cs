using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//Franklin Noe Solorzano Erazo

namespace Bebidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Venta venta = new Venta();
            venta.Compra();

        }
    }
}
//Datos de la bebida
public abstract class Bebida
{
    public string nombreBebida { get; set; }
    public string tipo { get; set; }
    public string categoria { get; set; }
    public string preparacion { get; set; }
    public string nombreCliente { get; set; }
    public int edad { get; set; }
    public string empleado { get; set; }

}

public class Venta : Bebida
{
    public Venta(string nombreBebida, string tipo, string categoria, string nombreCliente, int edad, string empleado, string preparacion)
    {
        this.nombreBebida = nombreBebida;
        this.tipo = tipo;
        this.categoria = categoria;
        this.nombreCliente = nombreCliente;
        this.edad = edad;
        this.empleado = empleado;
        this.preparacion = preparacion;
    }

    public Venta()
    {
    }

    public void Compra()
    {
        int opc;
        do
        {//Menu de bebidas
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Selecciona una opcion");
            Console.WriteLine("1. Café");
            Console.WriteLine("2.  Chocolate de almendra");
            Console.WriteLine("3. Cerveza");
            Console.WriteLine("4. Ron");
            opc = int.Parse(Console.ReadLine());


            if (opc == 1)
            {
                Console.Clear();
                Console.WriteLine("Haz seleccionado Café");
                Console.WriteLine("\nPor favor ingrese su nombre: ");
                nombreCliente = Console.ReadLine();
                Console.WriteLine("\nPor favor ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("****Detalles Orden****");
                empleado = "Mario Perez";
                Console.WriteLine("\nEstas siendo atendido por: " + empleado);
                Console.WriteLine("\n****Haz seleccionado la opcion de Café****");
                nombreBebida = "Café";
                categoria = "Cafeina";
                tipo = "Café negro";
                preparacion = "Cafe, dos cucharas de azucar";
                Console.WriteLine("\n****Factura****" +
                          "\nNombre del cliente: " + nombreCliente +
                          "\nEdad del cliente: " + edad +
                          "\nNombre de la bebida: " + nombreBebida +
                          "\nCategoría: " + categoria +
                          "\nTipo: " + tipo +
                          "\nPreparación: " + preparacion +
                          "\nTOTAL: 3.50 $$$$");
                Console.WriteLine("\n1. Continuar");
                Console.WriteLine("\n2. Volver al menu principal");
                int opc2 = int.Parse(Console.ReadLine());
                if (opc2 == 1)
                {
                    Console.WriteLine("Tu compra fue realizada, Muchas gracias por su compra!!");
                }
                else
                {
                    Console.Clear();
                    Compra();
                }

                break;


            }
            if (opc == 2)
            {
                Console.Clear();
                Console.WriteLine("Haz seleccionado Chocolate");
                Console.WriteLine("\nPor favor ingrese su nombre: ");
                nombreCliente = Console.ReadLine();
                Console.WriteLine("\nPor favor ingrese su edad tu edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.Clear();


                Console.WriteLine("****Detalles Orden****");
                empleado = "Maria Menjivar";
                Console.WriteLine("\nEstas siendo atendido por: " + empleado);
                Console.WriteLine("\n****Haz comprado un Chocolate de almendra****");
                nombreBebida = "Chocolate de almendra";
                categoria = "Chocolate Negro";
                tipo = "Bebida caliente";
                preparacion = "Chocolate, una cuchara de azucar, almendra molida";


                Console.WriteLine("\n****Factura****" +
                          "\nNombre del cliente: " + nombreCliente +
                          "\nEdad del cliente: " + edad +
                          "\nNombre de la bebida: " + nombreBebida +
                          "\nCategoría: " + categoria +
                          "\nTipo: " + tipo +
                          "\nPreparación: " + preparacion +
                          "\nTOTAL: 3.75 $$$$");
                Console.WriteLine("\n1. Continuar ");
                Console.WriteLine("\n2. Volver al menu principal");
                int opc3 = int.Parse(Console.ReadLine());
                if (opc3 == 1)
                {
                    Console.WriteLine("Tu compra fue realizada, Muchas gracias por la compra!!");
                }
                else
                {
                    Console.Clear();
                    Compra();
                }
                break;
            }
            if (opc == 3)
            {
                Console.Clear();
                Console.WriteLine("Haz seleccionado Cerveza");
                Console.WriteLine("\nPor favor ingrese su nombre: ");
                nombreCliente = Console.ReadLine();
                Console.WriteLine("\nPor favor ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());
                if (edad < 18)
                {
                    Console.WriteLine("Prohibida la venta de alcohol a menores de 18 años!!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("****Detalles Orden****");
                    empleado = "Sr. White";
                    Console.WriteLine("\nEstas siendo atendido por: " + empleado);
                    Console.WriteLine("\n****Haz seleccionado la opcion de Cerveza****");
                    nombreBebida = "Corona";
                    categoria = "Alcohol";
                    tipo = "Cerveza";
                    preparacion = "Malta, levadura, fermentacion";


                    Console.WriteLine("\n****Factura****" +
                              "\nNombre del cliente: " + nombreCliente +
                              "\nEdad del cliente: " + edad +
                              "\nNombre de la bebida: " + nombreBebida +
                              "\nCategoría: " + categoria +
                              "\nTipo: " + tipo +
                              "\nPreparación: " + preparacion +
                              "\nTOTAL: 1.50 $$$$");
                    Console.WriteLine("\n1. Continuar \t 2. Volver al menu principal");
                    int opc3 = int.Parse(Console.ReadLine());
                    if (opc3 == 1)
                    {
                        Console.WriteLine("Tu compra fue realizada, Muchas gracias por la compra!!");
                    }
                    else
                    {
                        Console.Clear();
                        Compra();
                    }
                }
                break;
            }
            if (opc == 4)
            {
                Console.Clear();
                Console.WriteLine("Haz seleccionado Ron");
                Console.WriteLine("\nPor favor ingrese su nombre: ");
                nombreCliente = Console.ReadLine();
                Console.WriteLine("\nPor favor ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());
                if (edad < 18)
                {
                    Console.WriteLine("Prohibida la venta de alcohol a menores de 18 años!!");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("****Detalles Orden****");
                    empleado = "Juan Carlos";
                    Console.WriteLine("\nEstas siendo atendido por: " + empleado);
                    Console.WriteLine("\n****Haz seleccionado la bebida de Ron****");
                    nombreBebida = "Barcelo";
                    categoria = "Alcohol";
                    tipo = "Ron";
                    preparacion = "Fermentacion";



                    Console.WriteLine("\n****Factura****" +
                              "\nNombre del cliente: " + nombreCliente +
                              "\nEdad del cliente: " + edad +
                              "\nNombre de la bebida: " + nombreBebida +
                              "\nCategoría: " + categoria +
                              "\nTipo: " + tipo +
                              "\nPreparación: " + preparacion +
                              "\nTOTAL: 6.00 $$$$");
                    Console.WriteLine("\n1. Continuar");
                    Console.WriteLine("\n2. Volver al menu principal");
                    int opc3 = int.Parse(Console.ReadLine());
                    if (opc3 == 1)
                    {
                        Console.WriteLine("Tu compra fue realizada, Muchas gracias por la compra!!");
                    }
                    else
                    {
                        Console.Clear();
                        Compra();
                    }
                }
                break;
            }

        } while (opc <= 4);
    }

}