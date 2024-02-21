using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public Usuario oUsuario { get; set; }
        public Libro oLibro { get; set; }
        public DateTime FechaReserva { get; set; }
        public string EstadoReserva { get; set; }
        public bool Activo { get; set; }
    }
}
