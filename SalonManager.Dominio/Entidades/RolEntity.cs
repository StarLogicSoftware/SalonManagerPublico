using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonManager.Dominio.Entidades
{
    public class RolEntity:BaseEntity
    {
        [Required]
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
    }
}
