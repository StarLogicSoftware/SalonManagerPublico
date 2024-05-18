using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalonManager.Dominio.Enums;

namespace SalonManager.Dominio.Entidades
{
    public class Turno:BaseEntity
    {
        public EstadosTurnoEnum Estado;
        public string Descripcion { get; set; }
        [Range(0, Int32.MaxValue)]
        public int Precio { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}