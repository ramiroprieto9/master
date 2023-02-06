
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
    internal static class ProductoHandler
    {
        public static string cadenaConexion = "Data Source=LAPTOP-TLQMACS5;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static List<Producto> TraerProducto(long idUsuario)
        {
            List<Producto> producto = new List<Producto>();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                
                SqlCommand comando2 = new SqlCommand($"SELECT * FROM Producto WHERE IdUsuario = @idUsuario ", conn);
                comando2.Parameters.AddWithValue("@idUsuario", idUsuario);


                conn.Open();
                SqlDataReader reader = comando2.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Producto productoTemporal = new Producto();
                        productoTemporal.Id = reader.GetInt64(0);
                        productoTemporal.Descripciones = reader.GetString(1);
                        productoTemporal.Costo = reader.GetDecimal(2);
                        productoTemporal.PrecioVenta = reader.GetDecimal(3);
                        productoTemporal.Stock = reader.GetInt32(4);
                        productoTemporal.IdUsuario = reader.GetInt64(5);

                        producto.Add(productoTemporal);
                    }
                    
                }
                return producto;

            }

        }


        public static Producto TraerProducto2(long idProducto)
        {
            Producto producto = new Producto();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT Producto.Descripciones FROM Producto\r\n  WHERE Producto.Id = @idProducto", conn);
                comando.Parameters.AddWithValue("@idProducto", idProducto);

                conn.Open();

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();

                    producto.Descripciones = reader.GetString(0);
                }
                return producto;
            }
        }

    }
}














