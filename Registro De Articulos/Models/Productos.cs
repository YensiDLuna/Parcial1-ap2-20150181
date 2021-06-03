using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Registro_De_Articulos.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        [Required(ErrorMessage = "Ingrese una Descripcion")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Ingrese una exitencia ")]
        public decimal Existencia { get; set; }
        [Required(ErrorMessage = "Ingrese un Costo")]
        public decimal Costo { get; set; }

        public decimal ValorInventario { get; set; }

    }
}
