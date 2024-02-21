using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Carrito
    {
        public int IdCarrito { get; set; }
        public Usuario oUsuario { get; set; }
        public Libro oLibro { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaAgregado { get; set; }
        public bool Activo { get; set; }
    }
}
