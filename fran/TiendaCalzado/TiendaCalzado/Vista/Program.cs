using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaCalzado.Entidades;
using TiendaCalzado.Negocio;

namespace TiendaCalzado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int store;
            Console.WriteLine("********Bienvenido seas AL COJO FELIZ**********");
            Console.WriteLine("\n");
            Console.WriteLine("¿En cual de todas nuestras tiendas te gustaria ver nuestro catalogo de calzado?");
            Console.WriteLine("1--Par2");
            Console.WriteLine("2--ADOC");
            Console.WriteLine("3--MD");
            

            store = int.Parse(Console.ReadLine());
            switch (store)
            {
                case 1:                   
                    Console.WriteLine("Podrias decirnos que calzado estas buscando");
                    Console.WriteLine("1--Hombre");
                    Console.WriteLine("2--Mujer");
                    Console.ReadLine();


                    break;
                case 2:
                    Console.WriteLine();
                    break;
                
                default:                  
                    break;

            }
        }
    }
}
