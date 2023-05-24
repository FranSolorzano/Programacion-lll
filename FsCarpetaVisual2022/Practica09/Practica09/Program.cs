using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            /*persona.capturarDatos();
            persona.Caminar();*/
            persona.mostrarDatos();


            Empleado emple = new Empleado();
            emple.capturarDatos();
        }
    }
}
