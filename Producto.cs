using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_13
{
    internal class Producto
    {
        public long Id { get; set; }
        public string Descripciones { get; set; }
        public long IdUsuario { get; set; }
        public int Stock { get; set; }
        public decimal Costo { get; set; }
        public decimal PrecioVenta { get; set; }

        //internal void Add(Producto producto)
        //{
        //    throw new NotImplementedException();
        //}

        //internal void Add(Producto productoTemporal)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
