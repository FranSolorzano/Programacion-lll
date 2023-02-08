using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //distanciamos las clases creando variables para poder mandarla a llamar

            Persona persona1 = new Persona();

            //aca le aplicamos valor a nuestras variables y las imprimimos

            persona1.Nombre = "Franklin";
            Console.WriteLine(persona1.Nombre);

            Estudiante estudiante= new Estudiante();
            estudiante.Nombre = persona1.Nombre + " NOÉ";
            Console.WriteLine(estudiante.Nombre);
            Console.ReadLine();
        }
    }

    class Persona
    {
        //declaramos variables si las hacemos privadas no las podemos distanciar fuera del metodo

        private string nombre;
        public string Nombre
        {
            get{ return nombre;}
            set { nombre= value;}
        }
        public int edad;
        public string peso;
        public string altura;

        //declaramos metodos

        public void Comer()
        {
            Console.WriteLine("Soy capaz de comer todo tipo de comida");
        }

        public void Caminar()
        {
            Console.WriteLine("Soy capaz de moverme");
        }
    }

    class Estudiante : Persona 
    {
       public void Aprender()
        {
            Console.WriteLine("Aprendo programacion");
        }
    }

}
