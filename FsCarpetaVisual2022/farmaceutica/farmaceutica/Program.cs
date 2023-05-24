using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmaceutica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente persona = new Cliente();
            persona.capturarDatos();           
            persona.mostrarDatos();

            Medicamentos medica = new Medicamentos();
            medica.Catalogo();
        }
    }
}
