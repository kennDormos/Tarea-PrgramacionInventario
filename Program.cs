using System;


namespace Tarea_PrgramacionInventario
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();
            bool salir = false;
            Console.WriteLine("Bienvenido al Sistema de Gestión de Inventario");

            while (!salir)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Agregar Producto");
                Console.WriteLine("2. Actualizar Precio de un Producto");
                Console.WriteLine("3. Eliminar Producto");
                Console.WriteLine("4. Contar Productos por Rango de Precio");
                Console.WriteLine("5. Ver Inventario Completo");
                Console.WriteLine("6. Generar Reporte Resumido");
                Console.WriteLine("7. Salir");
                Console.Write("Opción: ");
            }
            

            
        }
    }






}
    

