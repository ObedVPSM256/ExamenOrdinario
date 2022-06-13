using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExamenOrdinario
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables auxiliares
            string Producto;
            int Cantidad;
            float Precio;

            StreamWriter sw = new StreamWriter("Beta.txt", true);

            try
            {
                Console.WriteLine("*** ESCRIBA LOS DATOS SOLICITADOS ***");
                Console.Write("Nombre del producto: ");
                Producto = Console.ReadLine();
                Console.Write("Cantidad del producto: ");
                Cantidad = Convert.ToInt32(Console.ReadLine());
                Console.Write("Precio del producto: ");
                Precio = float.Parse(Console.ReadLine());
                //creación objeto
                Productos Prod = new Productos(Producto, Cantidad, Precio);
                sw.WriteLine(Prod.Producto + " " + Prod.Cantidad + " " + Prod.Precio);
                //cerrar StreamWriter
                sw.Close();
                //limpiar consola
                Console.Clear();
                //método para mostrar archivo
                Prod.MostrarArchivo();
                //cerrar programa
                Console.WriteLine("Presione <enter> para finalizar programa");
                Console.ReadKey();
            }

            //captura de posibles errores
            catch(IOException e)
            {
                Console.WriteLine("\nError : " + e.Message);
                Console.WriteLine("\nRuta : " + e.StackTrace);
            }
            catch(FormatException e)
            {
                Console.WriteLine("\nError : " + e.Message);
                Console.WriteLine("\nRuta : " + e.StackTrace);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("\nError : " + e.Message);
                Console.WriteLine("\nRuta : " + e.StackTrace);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("\nError : " + e.Message);
                Console.WriteLine("\nRuta : " + e.StackTrace);
            }
        }
    }
}
