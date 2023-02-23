using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


public abstract class Departamento
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
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
        this.departamento = departamento;
        this.municipio = municipio;
    }



    public void IngresarDatos()
    {
        int opc;

        do
        {
            WriteLine("\nPor favor selecciona una opción");
            WriteLine("\n1.Ingresar Datos");
            WriteLine("\n2.Salir");
            opc = int.Parse(ReadLine());


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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre +" " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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
                                WriteLine("Tus datos son: " + nombre + " " + edad + " " + departamento + " " + municipio);
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

    }
}

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