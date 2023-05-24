using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticaSemana1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ballena B = new Ballena("Wally");
            Caballo C = new Caballo("Toni");
            Persona P = new Persona("Pedro");
            Gorila G = new Gorila("Gordom");
            Cocodrilo Co = new Cocodrilo("Crocodile");

        }

        abstract class Animales
        {
            
        }
        class Reptil : Animales
        {
            public Reptil(string nombre)
            {
                String nombreSerVivo = nombre;
            }
        }

        

        public override void getnombre()
        {
            Console.WriteLine("El nombre del ser vivo es: " + nombre);
        }
        class Mamifero
        {
            
        }
        public class Ballena : Mamifero 
        
        {
            public Ballena(string ballena)
            {

            }

            

        public void nadar()
        {
            Console.WriteLine("Nada rapido");

        }

        public void respirar()
        {
            Console.WriteLine("Respira fuerte");
        }

        public void pensar()
        {
            Console.WriteLine("Piensa poco");
        }
        
        public void morder()
        {
            Console.WriteLine("muerde a vocados");
        }


    }

    public class Caballo

    { 
        public Caballo(string ballena)
            {

            }


            public void correr()
            {
                Console.WriteLine("El caballo corre muy rapido");
            }
            
            public void comer()
            {
                Console.WriteLine("El caballo come bastante al dia");
            }

            
          
    }


     

    }

    
}
