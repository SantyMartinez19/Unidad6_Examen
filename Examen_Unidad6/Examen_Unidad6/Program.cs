using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Examen_Unidad6
{
    //Examen Unidad 6
    //Alumno: Santy Francisco Martinez Castellanos
    //No.Control: 21211989
    public class Amazon
    {
        string nombre;
        string descripcion;
        float precio;
        int cantidad;

       
        public void CrearInventario()
        {
            StreamWriter sw = new StreamWriter("Productos.txt", true);
            try
            {
                
                Console.Write("Indica el nombre del producto:");
                nombre = Console.ReadLine();

                sw.WriteLine("Nombre del producto: {0}", nombre);

                Console.Write("Indica la descripcion del producto:");
                descripcion = Console.ReadLine();
                sw.WriteLine("Descripcion: {0}", descripcion);

                Console.Write("Indica el precio del producto:");
                precio = float.Parse(Console.ReadLine());
                sw.WriteLine("Precio: {0:C}", precio);

                Console.Write("Indica la cantidad en stock:");
                cantidad = int.Parse(Console.ReadLine());
                sw.WriteLine("Cantidad en stock: {0}", cantidad);

                sw.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }

       
            catch (IOException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }

            catch(Exception e)
            {
                Console.WriteLine("Erro: {0}", e.Message);
            }

            finally
            {
                if(sw != null)
                    sw.Close();
            }
           
            Console.WriteLine("Escribiendo en el archivo....");
        }
        

        public void LeerInventario()
        {
            StreamReader sr = null;
            String spp;

            try
            {
           
                sr = new StreamReader("Productos.txt");
                spp = sr.ReadLine();
                while (spp != null)
                {
                    Console.WriteLine(spp);
                    spp = sr.ReadLine();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: {0} ", e.Message);
           
            }
            finally
            {
                if (sr != null) 
                    sr.Close();
            }
        }

    }
        

    class Program
    {
        static void Main(string[] args)
        {
            Amazon a = new Amazon();

            char opc;
            do
            {
                Console.WriteLine("~~~Bienvenido a INVETARIO AMAZON~~~");
                Console.WriteLine("Menu de opciones");
                Console.WriteLine("a) Capturar los datos de un producto");
                Console.WriteLine("b) Consultar productos registrados");
                Console.WriteLine("c) Salir del programa");
                Console.Write("Elige una opcion:");
                opc = Console.ReadKey().KeyChar;
                switch (opc)
                {
                    case 'a':
                        Console.Clear();
                        Console.WriteLine("~~~REGISTRA UN PRODUCTO~~~");
                        Console.WriteLine("Ingresa la informacion solicitada");
                        a.CrearInventario();
                        Console.WriteLine("Presione enter");
                        Console.ReadKey();
                        Console.Clear();
                        break;



                    case 'b':
                        Console.Clear();
                        Console.WriteLine("~~~PRODUCTOS REGISTRADOS~~~");
                        a.LeerInventario();
                        Console.WriteLine("Presione enter");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case 'c':
                        Console.WriteLine();
                        Console.WriteLine("Has terminado");
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Opcion  Incorrecta");
                        Console.WriteLine("Presione enter");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (opc != 'c');

            Console.WriteLine("...Gracias por utilizar el programa... ^_^ ");
        }
    }
}
