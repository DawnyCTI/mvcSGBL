using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public Usuario oUsuario { get; set; }
        public Libro oLibro { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public string EstadoPrestamo { get; set; }
        public bool Activo { get; set; }
    }
}
