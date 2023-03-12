using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaCalzado.Entidades
{
    internal class ClsEntidades
    {
        public string nombre;
        public string apellido;
        public int talla;
        public string sexo;
        public string tienda;
        public string marca;
        public string estilo;
        public string descripcion;
        public double descuento;
        public int cantidad;
        public double precio;

        public ClsEntidades(string nombre, string apellido, int talla, string sexo, string tienda, string marca, string estilo, string descripcion, double descuento, int cantidad, double precio)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.talla = talla;
            this.sexo = sexo;
            this.tienda = tienda;
            this.marca = marca;
            this.estilo = estilo;
            this.descripcion = descripcion;
            this.descuento = descuento;
            this.cantidad = cantidad;
            this.precio = precio;
        }
    }
}
