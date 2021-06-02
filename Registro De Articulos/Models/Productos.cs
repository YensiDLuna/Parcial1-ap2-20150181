using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_De_Articulos.Models
{
    public class Productos
    {
        public int ProductoId { get; set; }
        public int Descripcion { get; set; }
        public int Existencia { get; set; }
        public int Costo { get; set; }
        public int ValorInventario { get; set; }

    }
}
