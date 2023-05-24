using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemA
{
    public class Class1
    {
        public void Mensaje()
        {
            Console.WriteLine("Hola estudiantes de programacion");
        }
    }

    public class Class2
    {
        public void Mensaje()
        {
            Class1 c = new Class1();
            c.Mensaje();
        }
    }
}
