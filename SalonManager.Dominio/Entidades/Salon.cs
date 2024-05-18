using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonManager.Dominio.Entidades
{
    public class Salon:UsuarioEntity
    {
        public List<Cliente> Clientes { get; set; }
    }
}
