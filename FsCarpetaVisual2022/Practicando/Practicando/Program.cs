using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//sistema de venta de comida rapida

public interface IDatos
{
    string Detalles();
}

public abstract class Datos
{
    public string nombre { get; set; }
    public string apellido { get; set; }
    public string localidad { get; set; }
    public int edad { get; set; }
    public string telefono { get; set; }
    public string categoria { get; set; }
    public string caracteristica { get; set; }
    public string tipo { get; set; }
    public string descripcion { get; set; }
    public double precio { get; set; }

    public abstract string Detalles();
}

public class Comida : Datos, IDatos
{
    public Comida() { }  //Constructor vacio

    public Comida(string Nombre, string Tipo, string Categoria, string Descripcion, double Precio)
    {
        this.nombre = Nombre;
        this.tipo = Tipo;
        this.categoria = Categoria;
        this.descripcion = Descripcion;
        this.precio = Precio;
    }
    public override string Detalles()
    {
        return "Comida: " + nombre +
            "\nTipo: " + tipo +
            "\nCategoria: " + categoria +
            "\nDescripción: " + descripcion +
            "\nPrecio: " + precio;
    }

    public void Comidas(string comida1, string comida2, string comida3, string comida4, string comida5)
    {

    }
}



namespace Practicando
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
