using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmaceutica
{
    internal class Cliente
    {
        bool Boleta;
        string nombre;
        string apellido;
        int edad;
        string dui;       
        string direccion;      
        int telefono;
        public void capturarDatos()
        {
            Console.WriteLine("***************BIENVENIDOS A FARMACIA LA DOLAMA***************");
            Console.WriteLine("\n");
            Console.WriteLine("¿Usted viene de manera privada o particular?"); //POR LA BOLETA O RECETA
            Console.WriteLine("1--SI");
            Console.WriteLine("2--NO");
            Console.WriteLine("Por favor seria tan amable de ingresar sus datos");
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese su numero de identificacion personal: ");
            dui = Console.ReadLine();
            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su direccion: ");
            direccion = Console.ReadLine();
            Console.WriteLine("Ingrese su numero telefonico: ");
            telefono = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }
        public void mostrarDatos()
        {
            Console.WriteLine("------DATOS DEL CLIENTE------");    
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Apellido: {apellido}");
            Console.WriteLine($"DUI: {dui}");
            Console.WriteLine($"Edad: {edad}");           
            Console.WriteLine($"Direccion: {direccion}");           
            Console.WriteLine($"Telefono: {telefono}");           
        }
    }
}
