using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_13
{
    internal class ProductoVendido
    {
        public long Id { get; set; }
        public long IdUsuario { get; set; }
        public long idVenta { get; set; }
        public int Stock { get; set; }
    }
}
