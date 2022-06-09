using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcClientes.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es Requerido")]
        [MaxLength(80)]
        public string Nombre { get; set; }
        [Required(ErrorMessage ="El Apellido es Requerido")]
        [MaxLength(80)]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "La Direccion es Requerida")]
        [MaxLength(80)]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "La Localidad es Requerida")]
        [MaxLength(80)]
        public string Localidad { get; set; }
        [Required(ErrorMessage = "El Telefono es Requerido")]
        public int Telefono { get; set; }

        [Required(ErrorMessage = "El Email es Requerido")]
        [MaxLength(80)]
        public string Email { get; set; }
   
        public bool Estado { get; set; }
    }
}
