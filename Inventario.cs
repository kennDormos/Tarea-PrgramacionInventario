using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_PrgramacionInventario
{
    public class Inventario
    {
        private List<Producto> productos;

        public Inventario() 
        {
            productos = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public Producto ActualizarPrecio(string nombre, decimal nuevoPrecio)
        {
            var producto = productos.FirstOrDefault(p => p.Nombre == nombre);
            if (producto != null)
            {
                producto.Precio = nuevoPrecio;
                return producto;
            }
            return null;
        }

        public bool EliminarProducto(string nombre)
        {
            var producto = productos.FirstOrDefault(p => p.Nombre == nombre);
            if (producto != null)
            {
                productos.Remove(producto);
                return true; 
            }
            return false; 
        }

        public int ContarProductosPorRango(decimal precioMinimo, decimal precioMaximo)
        {
            return productos.Count(p => p.Precio >= precioMinimo && p.Precio <= precioMaximo);
        }

        public void GenerarReporteResumido()
        {
            if (productos.Count == 0)
            {
                Console.WriteLine("No hay productos en el inventario.");
                return;
            }

            int totalProductos = productos.Count;
            decimal precioPromedio = productos.Average(p => p.Precio);
            var productoMasCaro = productos.OrderByDescending(p => p.Precio).First();
            var productoMasBarato = productos.OrderBy(p => p.Precio).First();

            Console.WriteLine("--- Reporte Resumido del Inventario ---");
            Console.WriteLine($"Número total de productos: {totalProductos}");
            Console.WriteLine($"Precio promedio de todos los productos: {precioPromedio:C}");
            Console.WriteLine($"Producto más caro: {productoMasCaro.Nombre} - {productoMasCaro.Precio:C}");
            Console.WriteLine($"Producto más barato: {productoMasBarato.Nombre} - {productoMasBarato.Precio:C}");
        }

        public List<Producto> ObtenerProductos()
        {
            return productos;
        }


    }
}
