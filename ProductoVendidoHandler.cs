
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.PortableExecutable;
namespace clase_13
{
    internal static class ProductoVendidoHandler
    {
        public static string cadenaConexion = "Data Source=LAPTOP-TLQMACS5;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static List<Producto> TraerProductosVendidos(long idUsuario)
        {
            List<Producto> productoVendido = new List<Producto>();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM ProductoVendido\r\n  INNER JOIN Venta\r\n  ON Venta.Id = ProductoVendido.IdVenta\r\n  WHERE Venta.IdUsuario =@idUsuario", conn);
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                conn.Open();

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto productoTemporal = ProductoHandler.TraerProducto2(reader.GetInt64(0));

                        productoVendido.Add(productoTemporal);
                    }
                }
            }
            return productoVendido;
        }
    }
}
