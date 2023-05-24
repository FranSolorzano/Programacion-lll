using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



//el cliente debe de ser mayor de edad para las bebidas frias


public interface IDatos
{

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

    public string DatosCliente()
    {

        string adios = "El empleado : " + this.nombre + " se despide cordealmente";
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

            Cliente cliente = new Cliente(nombre, apellido,edad, telefono, direccion);

            Console.WriteLine("****************BIENVENIDOS A BEBIDAS RANCEAS****************");
            Console.WriteLine("\n");

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
        }
    }
}
