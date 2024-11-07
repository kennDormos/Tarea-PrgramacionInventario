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

                if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 1 || opcion > 7)
                {
                    Console.WriteLine("Por favor, ingrese una opción válida (1-7).");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        AgregarProducto(inventario);
                        break;
                    case 7:
                        salir = true;
                        Console.WriteLine("Saliendo del sistema. ¡Gracias!");
                        break;
                }
            }
            static void AgregarProducto(Inventario inventario)
            {
                Console.Write("Nombre del Producto: ");
                string nombre = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(nombre))
                {
                    Console.Write("El nombre no puede estar vacío. Ingrese el nombre del Producto: ");
                    nombre = Console.ReadLine();
                }

                decimal precio;
                
                while (true)
                {
                    Console.Write("Precio del Producto: ");
                    if (decimal.TryParse(Console.ReadLine(), out precio) && precio > 0)
                    {
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Precio inválido. Asegúrese de ingresar un número positivo.");
                    }
                }

                
                inventario.AgregarProducto(new Producto(nombre, precio));
                Console.WriteLine("Producto agregado exitosamente.");


            }
        }
    }
}
   
    







    

