using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public abstract class Datos
{
    public string nombre { get; set; }
    public int edad { get; set; }
    public string departamento { get; set; }
    public string municipio { get; set; }

    public abstract string Detalles();
}

public class Usuario : Datos
{
    public Usuario() { }

    public Usuario(string nombre, int edad)
    { this.nombre = nombre;
    this.edad = edad;}

    public override string Detalles()
    {
        return "Nombre: " + nombre +
           "\nEdad: " + edad;
    }
}


public class lugar : Datos
{
    public lugar() { }

    public lugar(string departamento, string municipio)
    { this.departamento = departamento;
    this.municipio = municipio;}

    public override string Detalles()
    {
        return "Departamento: " + departamento +
           "\nMunicipio: " + municipio;
    }

    public void departamentos(string departamento1, string departamento2, string departamento3, string departamento4, string departamento5, string departamento6, string departamento7, string departamento8, string municipio1, string municipio2, string municipio3, string municipio4, string municipio5, string municipio6, string municipio7, string municipio8, string mombre, int edad)
    {
        Console.WriteLine("\n++++++++++++++++++++ Bebidas ++++++++++++++++++++");
        Console.WriteLine("1-" + departamento1 + "\n2-" + departamento2 + "\n3-" + departamento3 + "\n4-" + departamento4 + "\n5-" + departamento5 + "\n6-" + departamento6 + "\n7-" + departamento7 + "\n8-" + departamento8);
        Console.WriteLine("\nElige el departamento del que provienes: ");
        int opc = int.Parse(Console.ReadLine());

        if (opc == 1)
        {
            Registro r = new Registro();
            r.Datos(departamento1, municipio1, nombre, edad);
        }
        else if (opc == 2)
        {
            Registro r = new Registro();
            r.Datos(departamento2, municipio, nombre, edad);
        }
        else if (opc == 3)
        {
            Registro r = new Registro();
            r.Datos(departamento3, municipio, nombre, edad);
        }
        else if (opc == 4)
        {
            Registro r = new Registro();
            r.Datos(departamento4, municipio, nombre, edad);
        }
        else if (opc == 5)
        {
            Registro r = new Registro();
            r.Datos(departamento5, municipio, nombre, edad);
        }
        else if (opc == 6)
        {
            Registro r = new Registro();
            r.Datos(departamento6, municipio, nombre, edad);
        }
        else if (opc == 7)
        {
            Registro r = new Registro();
            r.Datos(departamento7, municipio, nombre, edad);
        }
        else if (opc == 8)
        {
            Registro r = new Registro();
            r.Datos(departamento8, municipio, nombre, edad);
        }
        else
        {
            Console.WriteLine("Opción inválida!");
        }


    }

}


public class Registro
{
    public void Datos(string nombre, int edad, string Departamentos, string Municipios)
    {
        Usuario c = new Usuario(nombre, edad);
        Console.WriteLine(c.Detalles());

        lugar b = new lugar(Departamentos, Municipios);
        Console.WriteLine(b.Detalles());       

        Console.WriteLine("----------------------------------------------------------");
    }

    public void Registrar(string ficha)
    {
        Console.WriteLine("\n----------------Ingresa tus datos----------------");
        Console.WriteLine("Nombre: ");
        string nombre = Console.ReadLine();      

        Console.WriteLine("Edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("\n*****************DEPARTAMENTOS*****************");
        Console.WriteLine("1-CHALATENANGO" + "\n2-SAN MIGUEL" + "\n3-AHUACHAPAN" + "\n4-MORAZAN" + "\n5-LA LIBERTAD + \"\\n6-LA UNION+ \"\\n7-SON SONATE + \"\\n8-LA PAZ");

        Console.WriteLine("Elige el departamento: ");
        int opc = int.Parse(Console.ReadLine());


        if (opc == 1)
        {
            string departamento1 = "Chalatenango";
            string departamento2 = "La Nueva";
            string departamento3 = "La Palma";
            string departamento4 = "Comalapa";
            string departamento5 = "Azacualpá";          
            string departamento6 = "Citala";          
            string departamento7 = "Arcatao";          
            string departamento8 = "Agua Caliente";          
            
            Console.Clear();
            lugar b = new lugar();
            b.departamentos(departamento1, departamento2, departamento3, departamento4, departamento5, departamento6, departamento7, departamento8, municipio,nombre, edad);
        }
        else if (opc == 2)
        {
            string departamento1 = "San Gerardo";
            string departamento2 = "Quelepa";
            string departamento3 = "Moncagua";
            string departamento4 = "Uluasapa";
            string departamento5 = "San Rafael Oriente";
            string departamento6 = "San Antonio del Mosco";
            string departamento7 = "Comacaran";
            string departamento8 = "Chinameca";

            Console.Clear();
            lugar b = new lugar();
            b.departamentos(departamento1, departamento2, departamento3, departamento4, departamento5, departamento6, departamento7, departamento8, municipio, nombre, edad);
        }
        else if (opc == 3)
        {
            string departamento1 = "San Lorenzo";
            string departamento2 = "El refugio";
            string departamento3 = "Moncagua";
            string departamento4 = "Uluasapa";
            string departamento5 = "San Rafael Oriente";
            string departamento6 = "San Antonio del Mosco";
            string departamento7 = "Comacaran";
            string departamento8 = "Chinameca";

            Console.Clear();
            lugar b = new lugar();
            b.departamentos(departamento1, departamento2, departamento3, departamento4, departamento5, departamento6, departamento7, departamento8, municipio, nombre, edad);
        }
        else if (opc == 4)
        {
            if (edad >= 18)
            {
                string sabor1 = "Bulleit Frontier";
                string sabor2 = "Cardhu Gold Reserve";
                string sabor3 = "Lagavulin";
                string sabor4 = "Talisker";
                string sabor5 = "Macallan";
                string tipo = "Whisky";
                string categoria = "Alcohólico";
                string descripcion = "Whiskito";
                double precio = 25.75;

                Clear();
                Bebida b = new Bebida();
                b.Bebidas(sabor1, sabor2, sabor3, sabor4, sabor5, tipo, categoria, descripcion, precio, asesor, nombre, apellido, edad, sexo);
            }
            else
            {
                WriteLine("\nEres menor de edad!");
            }
        }
        else if (opc == 5)
        {
            if (edad >= 18)
            {
                string sabor1 = "Advocaat";
                string sabor2 = "Kummel";
                string sabor3 = "Absenta";
                string sabor4 = "Sambuca";
                string sabor5 = "Triple Sec";
                string tipo = "Licor";
                string categoria = "Alcohólico";
                string descripcion = "Licorsito";
                double precio = 23.5;

                Clear();
                Bebida b = new Bebida();
                b.Bebidas(sabor1, sabor2, sabor3, sabor4, sabor5, tipo, categoria, descripcion, precio, asesor, nombre, apellido, edad, sexo);
            }
            else
            {
                WriteLine("\nEres menor de edad!");
            }
        }
        else
        {
            WriteLine("\nOpción inválida!");
        }
    }
}





namespace Laboratorio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //menu departamentos 8 municipios por departamento

            //menu ususario

            Console.WriteLine("¿Que desea realizar?");
            Console.WriteLine("1--Registrarse");
            Console.WriteLine("2--Mostrar datos del registro");
            Console.WriteLine("3--Salir");
            int opciones = int.Parse(Console.ReadLine());

            switch(opciones)
            {
                case 1:
                    int Registrarse; 

                    break;
                case 2:
                    int MostrarDatos;
                    break; 
                case 3:
                    int Salir;
                    break;
                            
            }
        }
    }
}
