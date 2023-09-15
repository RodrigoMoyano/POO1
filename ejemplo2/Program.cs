using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primer lote con 10 registros de productos, cada producto tiene:
            //- Codigo Articulo (3 digitos no correlativos)
            //- Precio
            //- Codigo de Marca (1 a 10)
            //Segundo lote con las ventas de la semana. Cada venta tiene:
            //- Codigo de Articulo
            //- Cantidad
            //- Codigo Cliente (1 a 100)
            //Este lote corta con Codigo de Cliente cero.

            //En vez de cargar los datos uno por uno, creadno un vector de 10
            //para cada registro, creo un solo vector de articulos
            Articulo[] articulos = new Articulo[10];

            //articulos[6].CodigoMarca = 3;
            //Asi puedo cargar en la variable que yo quiera dandole la coordenada
            // el valor en este ej: Le cargo en el indice 6 de CodigoMarca un 3

            for (int x = 0; x < 10; x++)
            {
                articulos[x] = new Articulo();
                Console.WriteLine("Ingrese los datos del producto..");
                Console.WriteLine("Codigo:");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio:");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca (1 a 10)");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());

            }
            //Tengo carga el vector completo con los 10 articulos
            Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta:");
            Console.WriteLine("Codigo de Cliente");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            

            while (venta.CodigoCliente != 0)
            {
            
            Console.WriteLine("Codigo Articulo:");
            venta.CodigoArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad:");
            venta.Cantidad = int.Parse(Console.ReadLine());

                //trabajamos


                //pido cliente nuevamente
                Console.WriteLine("Ingrese la venta:");
                Console.WriteLine("Codigo de Cliente");
                venta.CodigoCliente = int.Parse(Console.ReadLine());

            }







        }
    }
}
