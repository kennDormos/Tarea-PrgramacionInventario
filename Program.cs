using System;


namespace Tarea_PrgramacionInventario
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            Console.WriteLine("Bienvenido al sistema de gestion de inventario");

            
            Console.Write("¿Cuántos productos desea ingresar? ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\nProducto {i + 1}:");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Precio: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                Producto producto = new Producto(nombre, precio);
                inventario.AgregarProductos(producto);
            }

            
            Console.Write("\nIngrese el precio mínimo para filtrar los productos: ");
            decimal precioMinimo = decimal.Parse(Console.ReadLine());

            
            var productosFiltrados = inventario.FiltrarYOrdenarProductos(precioMinimo);

            Console.WriteLine("\nProductos filtrados y ordenados:");
            foreach (var producto in productosFiltrados)
            {
                Console.WriteLine(producto);
            }
        }
    }
}
