using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonManager.Dominio.Entidades
{
    public class UsuarioEntity:PersonaEntity
    {
        [Required]
        [MaxLength(15)]
        public string Usuario { get; set; }

        [Required]
        [MinLength(8)]
        public string Contraseña { get; set; }

        public int RolId { get; set; }asdasd

        public RolEntity Rol { get; set; }
    }

}
