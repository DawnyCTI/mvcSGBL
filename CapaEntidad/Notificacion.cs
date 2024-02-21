using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Notificacion
    {
        public int IdNotificacion { get; set; }
        public Usuario oUsuario { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaEnvio { get; set; }
        public bool Leido { get; set; }
        public bool Activo { get; set; }
    }
}
