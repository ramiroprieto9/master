using Azure;

namespace clase_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Traer Usuario segun IdUsuario\n");
            Usuario usuario = UsuarioHandler.TraerUsuario(2);
            Console.WriteLine(usuario.Id);
            Console.WriteLine(usuario.Nombre);
            Console.WriteLine(usuario.Apellido);
            Console.WriteLine(usuario.NombreUsuario);
            Console.WriteLine(usuario.Mail);


            Console.WriteLine("\nTraer Producto segun IdUsuario\n");
            List<Producto> productos = ProductoHandler.TraerProducto(1);

            foreach (Producto item in productos)
            {
                Console.WriteLine(item.Descripciones);
            }

            Console.WriteLine("\nTraer Productos Vendidos segun IdUsuario\n");
            List<Producto> productosvendidos = ProductoVendidoHandler.TraerProductosVendidos(1);

            foreach (Producto item in productosvendidos)
            {
                Console.WriteLine(item.Descripciones);
            }

            Console.WriteLine("\nTraer Ventas segun IdUsuario\n");
            List<Venta> ventas = VentasHandler.TraerVentas(1);

            foreach (Venta item in ventas)
            {
                Console.WriteLine("{0}",item.Id);
            }


            Console.WriteLine("\nInicio de Sesion\n");
            Usuario inicioSesion = UsuarioHandler.InicioSesion("eperez", "SoyErnestoPerez");
            Console.WriteLine(usuario.Id);
            Console.WriteLine(usuario.Nombre);
            Console.WriteLine(usuario.Apellido);
            Console.WriteLine(usuario.NombreUsuario);
            Console.WriteLine(usuario.Mail);

            


            
        }
    }
}