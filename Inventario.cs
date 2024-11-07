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

        public void AgregarProductos(Producto producto)
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



    }
}
