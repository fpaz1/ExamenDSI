using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExamenFanorPaz.Models
{
    public partial class Producto
    {
        [Key]
        public int Id { get; set; } 
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public string? Categoria { get; set; }
    }
}
