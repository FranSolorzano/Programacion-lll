using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





public abstract class Persona
{
    public string Nombre { get; set; }

    public abstract string Saludar();
}

public class Alumno : Persona, IPersona
{
   public Alumno (string Nombre)
    {
        this.Nombre = Nombre;
    }

    public string Despedirse()
    {
        string adios = "E3l empleado : " + this.Nombre + " se despide cordealmente";
        return adios;
    }

    public override string Saludar()
    {
        string saludo = "Hola mi nombre es: " + this.Nombre + " y soy un alumno";
        return saludo;
    }
}


public class Empleado : Persona, IPersona
{
    public Empleado(string Nombre)
    {
        this.Nombre = Nombre;
    }

    public string Despedirse()
    {
        string adios = "E3l empleado : " + this.Nombre + " se despide cordealmente";
        return adios;
    }

    public override string Saludar()
    {
        string saludo = "Hola mi nombre es: " + this.Nombre + " y soy un empleado";
        return saludo;
    }

    
}


public interface IPersona 
{
    string Despedirse();

}



namespace Clase_4
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            IPersona[] persona = new IPersona[2];


            persona[0] = new Alumno("Franklin Solorzano");
            persona[1] = new Empleado("Pedro Salazar");

            for (int i = 0; i < persona.Length; i++)
            {
                Console.WriteLine(persona[i].Despedirse());
            }           
        }
    }
}
