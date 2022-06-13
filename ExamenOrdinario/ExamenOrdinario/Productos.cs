using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExamenOrdinario
{
    //declaración de clase pública
    public class Productos
    {
        //atributos de la clase
        public string Producto;
        public int Cantidad;
        public float Precio;

        //constructor de clase
        public Productos(string Producto, int Cantidad, float Precio)
        {
            this.Producto = Producto;
            this.Cantidad = Cantidad;
            this.Precio = Precio;
        }

        //metodos
        public void MostrarArchivo()
        {
            Console.WriteLine("Producto: " + this.Producto);
            Console.WriteLine("Cantidad: " + this.Cantidad);
            Console.WriteLine("Precio: " + this.Precio);
        }
    }
}
