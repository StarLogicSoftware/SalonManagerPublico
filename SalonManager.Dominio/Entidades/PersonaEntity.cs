using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonManager.Dominio.Entidades
{
    public class PersonaEntity : BaseEntity
    {
        [Required]
        [MaxLength(30, ErrorMessage = "El nombre no puede tener mas de 30 caracteres")]
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        [Required]
        public string Telefono { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
