using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_13
{
    internal static class VentasHandler
    {
        public static string cadenaConexion = "Data Source=LAPTOP-TLQMACS5;Initial Catalog=SistemaGestion;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static List<Venta> TraerVentas (long idUsuario)
        {
            List<Venta> ventas = new List<Venta> ();
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                SqlCommand comando = new SqlCommand("SELECT Venta.Id FROM Venta\r\n  INNER JOIN Usuario\r\n  ON Venta.IdUsuario = Usuario.Id\r\n  WHERE Venta.IdUsuario = @idUsuario", conn);
                comando.Parameters.AddWithValue ("@idUsuario", idUsuario);
                conn.Open();
                SqlDataReader reader= comando.ExecuteReader ();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Venta productoTemporal = new Venta();
                        productoTemporal.Id = reader.GetInt64(0);
                        ventas.Add(productoTemporal);
                    }
                    
                }
                return ventas;
            }
        }

    }
}
