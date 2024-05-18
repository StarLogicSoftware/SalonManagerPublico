using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonManager.Dominio.Entidades
{
    public class Cliente:UsuarioEntity
    {
        [Required]
        [MaxLength(30, ErrorMessage = "El apellido no puede tener mas de 30 caracteres")]
        public string Apellido { get; set; }
        public List<Turno> Turnos { get; set; }
    }
}
