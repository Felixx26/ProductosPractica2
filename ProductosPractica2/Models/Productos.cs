using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductosPractica2.Models
{
    public class Productos
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(40)]
        public string Categoria { get; set; }
        [Required]
        [StringLength(40)]
        public string Codigo { get; set; }
        [Required]
        public int Existencia { get; set; }
        [Required]
        public DateTime FechaFab { get; set; }
        [Required]
        public DateTime FechaVen { get; set; }
        [Required]
        public Boolean Estado { get; set; }
    }
}