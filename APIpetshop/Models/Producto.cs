using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIpetshop.Models
{
    public class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idProducto { get; set; }
        [Required]
        public string codigo { get; set; }
        [Required]
        public string nombre { get; set; }
        [Required]
        public double precio { get; set; }
        public int numero { get; set; }

      
    }
}

