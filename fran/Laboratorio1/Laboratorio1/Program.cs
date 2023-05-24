using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


<<<<<<< Updated upstream
public abstract class Departamento
=======


namespace Laboratorio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //menu departamentos 8 municipios por departamento

            //menu ususario

            Console.WriteLine("¿Que desea realizar?");
            Console.WriteLine("1--Registrarse");
            Console.WriteLine("2--Mostrar datos del registro");
            Console.WriteLine("3--Salir");
            int opciones = int.Parse(Console.ReadLine());

            Registro r = new Registro();

            //string ficha = "";
            //r.Registrar(ficha);


            //else if (opciones == 2)
            //{
            //    ficha = 2;
            //    int MostrarDatos;
            //}
            //else if (opciones == 3)
            //{
            //    ficha = 3;
            //    int MostrarDatos;
            //}
            //else
            //{
            //    Console.WriteLine("\nNo válido!");
            //}


            if (opciones == 1)
            {

            }



        }
    }
}
public abstract class Datos
>>>>>>> Stashed changes
{
    public string nombre { get; set; }
    public string apellido { get; set; }
    public int edad { get; set; }
    public string departamento { get; set; }
    public string municipio { get; set; }

}


public class User : Departamento
{
    public User()
    {
    }

    public User(string nombre, string apellido, int edad, string departamento, string municipio)
    {
<<<<<<< Updated upstream
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
        this.departamento = departamento;
        this.municipio = municipio;
=======
        Console.WriteLine("\n++++++++++++++++++++ Bebidas ++++++++++++++++++++");
        Console.WriteLine("1-" + departamento1 + "\n2-" + departamento2 + "\n3-" + departamento3 + "\n4-" + departamento4 + "\n5-" + departamento5 + "\n6-" + departamento6 + "\n7-" + departamento7 + "\n8-" + departamento8);
        Console.WriteLine("\nElige el departamento del que provienes: ");
        int opc = int.Parse(Console.ReadLine());

        if (opc == 1)
        {
            Registro r = new Registro();
            r.Datos(departamento1, municipio, nombre, edad);
        }
        else if (opc == 2)
        {
            Registro r = new Registro();
            r.Datos(departamento2, municipio, nombre, edad);
        }
        else if (opc == 3)
        {
            Registro r = new Registro();
            r.Datos(departamento3, municipio, nombre, edad);
        }
        else if (opc == 4)
        {
            Registro r = new Registro();
            r.Datos(departamento4, municipio, nombre, edad);
        }
        else if (opc == 5)
        {
            Registro r = new Registro();
            r.Datos(departamento5, municipio, nombre, edad);
        }
        else if (opc == 6)
        {
            Registro r = new Registro();
            r.Datos(departamento6, municipio, nombre, edad);
        }
        else if (opc == 7)
        {
            Registro r = new Registro();
            r.Datos(departamento7, municipio, nombre, edad);
        }
        else if (opc == 8)
        {
            Registro r = new Registro();
            r.Datos(departamento8, municipio, nombre, edad);
        }
        else
        {
            Console.WriteLine("Opción inválida!");
        }


>>>>>>> Stashed changes
    }



    public void IngresarDatos()
    {
        int opc;

        do
        {
<<<<<<< Updated upstream
            WriteLine("\nPor favor seleccione lo que desea realizar");
            WriteLine("\n1.Registrarse");
            WriteLine("\n2.Salir");
            opc = int.Parse(ReadLine());
=======
            string departamento1 = "Chalatenango";
            string departamento2 = "La Nueva";
            string departamento3 = "La Palma";
            string departamento4 = "Comalapa";
            string departamento5 = "Azacualpá";          
            string departamento6 = "Citala";          
            string departamento7 = "Arcatao";          
            string departamento8 = "Agua Caliente";
      
            
            Console.Clear();
            lugar b = new lugar();
            b.departamentos(departamento1, departamento2, departamento3, departamento4, departamento5, departamento6, departamento7, departamento8, municipio1,nombre, edad);
        }
        else if (opc == 2)
        {
            string departamento1 = "San Gerardo";
            string departamento2 = "Quelepa";
            string departamento3 = "Moncagua";
            string departamento4 = "Uluasapa";
            string departamento5 = "San Rafael Oriente";
            string departamento6 = "San Antonio del Mosco";
            string departamento7 = "Comacaran";
            string departamento8 = "Chinameca";
>>>>>>> Stashed changes


<<<<<<< Updated upstream
            if (opc == 1)
            {
                //DATOS DE LA PERSONA
                Clear();
                WriteLine("Por favor ingrese su nombre: ");
                nombre = ReadLine();              
                WriteLine("Por favor ingrese su edad");
                edad = int.Parse(ReadLine());
                WriteLine("\nSus datos son: " + nombre + " " + edad);


                WriteLine("\n1.Continuar ");
                WriteLine("\n2.Salir");
                opc = int.Parse(ReadLine());

                //MENU DE LOS DEPARTAMENTOS Y MUNICIPIOS

                if (opc == 1)
                {
                    int opc2;
                    Clear();
                    WriteLine("Seleccione un departamento");
                    WriteLine("1.Chalatenango" +
                        "\n2.Ahuachapán" +
                        "\n3.San Miguel" +
                        "\n4.San Salvador" +
                        "\n5.La Libertad");

                    //MENU DE LOS MUNICIPIOS
                    opc2 = int.Parse(ReadLine());
                    if (opc2 == 1)
                    {
                        int opc3;
                        Clear();
                        WriteLine("******Municipios del departamento de Chalatenango******");
                        WriteLine("\n1.Chalatenango " +
                            "\n2.Comalapa  " +
                            "\n3.Azacualpa " +
                            "\n4.Arcatao " +
                            "\n5.Agua Caliente ");
                        opc3 = int.Parse(ReadLine());


                        if (opc3 == 1)
                        {
                            departamento = "Chalatenango";
                            municipio = "Chalatenango";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if(opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();                              
                            }
                            
                        }
                        if (opc3 == 2)
                        {
                            departamento = "Chalatenango";
                            municipio = "Comalapa";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if(opc4 ==2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 3)
                        {
                            departamento = "Chalatenango";
                            municipio = "Azacualpa";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if(opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 4)
                        {
                            departamento = "Chalatenango";
                            municipio = "Arcatao";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if(opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 5)
                        {
                            departamento = "Chalatenango";
                            municipio = "Agua Caliente";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro ");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if(opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                    }
                    if (opc2 == 2)
                    {
                        int opc3;
                        Clear();
                        WriteLine("******Municipios del departamento de Ahuachapan******");
                        WriteLine("\n1.Ahuachapán " +
                            "\n2.Apaneca " +
                            "\n3.San Lorenzo " +
                            "\n4.Turin " +
                            "\n5.El Refugio");
                        opc3 = int.Parse(ReadLine());


                        if (opc3 == 1)
                        {
                            departamento = "Ahuachapan";
                            municipio = "Ahuachapan";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if(opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 2)
                        {
                            departamento = "Ahuachapan";
                            municipio = "Apaneca";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if(opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 3)
                        {
                            departamento = "Ahuachapan";
                            municipio = "San Lorenzo";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if(opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 4)
                        {
                            departamento = "Ahuachapan";
                            municipio = "Turin";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if(opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 5)
                        {
                            departamento = "Ahuachapan";
                            municipio = "El refugio";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if(opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                    }
                    if (opc2 == 3)
                    {

                        int opc3;
                        Clear();
                        WriteLine("******Municipios del departamento de San Miguel******");
                        WriteLine("\n1.San Gerardo " +
                            "\n2.San Rafael Oriente " +
                            "\n3.Chinameca " +
                            "\n4.Quelepa " +
                            "\n5.San Miguel");
                        opc3 = int.Parse(ReadLine());


                        if (opc3 == 1)
                        {
                            departamento = "San Miguel";
                            municipio = "San Gerardo";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if (opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 2)
                        {
                            departamento = "San Miguel";
                            municipio = "San Rafael Oriente";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if (opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 3)
                        {
                            departamento = "San Miguel";
                            municipio = ".Chinameca";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if (opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 4)
                        {
                            departamento = "San Miguel";
                            municipio = "Quelepa";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if (opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 5)
                        {
                            departamento = "San Miguel";
                            municipio = "San Miguel";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro ");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if (opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                    }
                    if (opc2 == 4)
                    {
                        int opc3;
                        Clear();
                        WriteLine("******Municipios del departamento de San Salvador******");
                        WriteLine("\n1.Guazapa" +
                            "\n2.Apopa" +
                            "\n3.Aguilares " +
                            "\n4.Ciudad Delgado " +
                            "\n5.Santa Tecla ");
                        opc3 = int.Parse(ReadLine());


                        if (opc3 == 1)
                        {
                            departamento = "San Salvador";
                            municipio = "Guazapa";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro ");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if (opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 2)
                        {
                            departamento = "San Salvador";
                            municipio = "Apopa";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if (opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 3)
                        {
                            departamento = "San Salvador";
                            municipio = "Aguilares";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if (opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 4)
                        {
                            departamento = "San Salvador";
                            municipio = "Ciudad Delgado";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if (opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 5)
                        {
                            departamento = "San Salvador";
                            municipio = "Santa Tecla";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if (opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                    }
                    if (opc2 == 5)
                    {

                        int opc3;
                        Clear();
                        WriteLine("******Municipios del departamento de La Libertad******");
                        WriteLine("\n1.Antiguo Cuscatlan " +
                            "\n2.Comasagua " +
                            "\n3.San Matias " +
                            "\n4.Ciudad Arce " +
                            "\n5.Colón");
                        opc3 = int.Parse(ReadLine());


                        if (opc3 == 1)
                        {
                            departamento = "La Libertad";
                            municipio = "Antiguo Cuscatlan";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro ");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if (opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 2)
                        {
                            departamento = "La Libertad";
                            municipio = "Comasagua";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if (opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 3)
                        {
                            departamento = "La Libertad";
                            municipio = "San Matias";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro ");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if (opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 4)
                        {
                            departamento = "La Libertad";
                            municipio = "Ciudad Arce";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if (opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                        if (opc3 == 5)
                        {
                            departamento = "La Libertad";
                            municipio = "Colon";
                            int opc4;
                            Clear();
                            WriteLine("\n1.Ingresar otro registro ");
                            WriteLine("\n2.Mostrar Registros");
                            opc4 = int.Parse(ReadLine());
                            if (opc4 == 1)
                            {
                                IngresarDatos();
                            }
                            if (opc4 == 2)
                            {
                                WriteLine("Tus datos son: " + nombre + " de edad: " + edad + ", del departamento de: " + departamento + " y del municipio de: " + municipio);
                                ReadKey();
                            }
                        }
                    }
                    break;
                }
            }
            else
            {
                Environment.Exit(0);
            }

        } while (opc <= 2);

=======
            Console.Clear();
            lugar b = new lugar();
            b.departamentos(departamento1, departamento2, departamento3, departamento4, departamento5, departamento6, departamento7, departamento8, municipio, nombre, edad);
        }
       
        else
        {
            Console.WriteLine("\nOpción inválida!");
        }
>>>>>>> Stashed changes
    }

<<<<<<< Updated upstream
namespace primerLaboratorio
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User u = new User();
            u.IngresarDatos();
        }
    }
}
=======
    internal void Datos(string departamento1, string municipio, string nombre, int edad)
    {
        throw new NotImplementedException();
    }
}






    
>>>>>>> Stashed changes
