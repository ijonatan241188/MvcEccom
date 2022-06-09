using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcClientes.Models
{
    public class Productos
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre del Producto es Requerido")]
        [MaxLength(80)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "La descripcion del Producto es Requerida")]
        [MaxLength(80)]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "La Imagen es requerida")]
    
        public string Imagen { get; set; }
        [Required(ErrorMessage = "Ingrese un monto")]
        
        public int Precio { get; set; }


    }
}
