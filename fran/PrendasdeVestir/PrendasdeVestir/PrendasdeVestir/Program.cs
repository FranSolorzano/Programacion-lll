using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


public abstract class Datos
{
    public string categoria;
    public string calidad;
    public string caracteristicas;
    public string diseño;
    public string tallas;
    public double precio;
    public string color;
    public string nombre;
    public string apellido;
    public string direccion;
    public string dui;
    public int numeroTelefonico;

    protected Datos(string categoria, string calidad, string caracteristicas, string diseño, string tallas, double precio, string color, string nombre, string apellido, string direccion, string dui, int numeroTelefonico)
    {
        this.categoria = categoria;
        this.calidad = calidad;
        this.caracteristicas = caracteristicas;
        this.diseño = diseño;
        this.tallas = tallas;
        this.precio = precio;
        this.color = color;
        this.nombre = nombre;
        this.apellido = apellido;
        this.direccion = direccion;
        this.dui = dui;
        this.numeroTelefonico = numeroTelefonico;
    }
}







namespace PrendasdeVestir
{
    internal class Program
    {
        static void Main(string[] args)
        {

            WriteLine("**********BIENVENIDO A TIENDA PACA**********");
            WriteLine("\n");
            WriteLine("Nosotros somos PACA y ofrecemos la mejor calidad de prendas de vestir, los mejores precios con un costo mas accesible \n" +
                "para toda nuestra familia PACA, le presentaremos a continuacion toda nuestra categoria de ropa con la cual contamos:");
            WriteLine("\n");
            WriteLine("Por favor seleccione el tipo de vestimenta que le gustaria visualizar");
            WriteLine("1--HOMBRE");
            WriteLine("\t2--MUJER");            
            int opc;

            
            WriteLine("------CATALOGO PACA DE HOMBRE------");  //CATALOGO PACA
            WriteLine("1--Camisetas");
            WriteLine("2--Pantalones");
            WriteLine("3--Shores");
            WriteLine("4--Calsetas");
            WriteLine("5--Ropa interior");
            WriteLine("6--Zapatos");

            WriteLine("------CATALOGO PACA DE MUJER------");  //CATALOGO PACA
            WriteLine("1--Blusas");
            WriteLine("2--Pantalones");
            WriteLine("3--Shores");
            WriteLine("3--Shores");
            WriteLine("4--Calsetas");
            WriteLine("5--Ropa interior");
            WriteLine("6--Zapatos");
          



            WriteLine("------MENU PACA------");  //CATALOGO PACA
            WriteLine("1--Tipo");
            WriteLine("2--Categoria");
            WriteLine("3--Descripcion");
            WriteLine("4--Talla");
            WriteLine("5--Precio");
        }
    }
}
