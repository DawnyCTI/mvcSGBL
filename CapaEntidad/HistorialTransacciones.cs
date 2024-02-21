using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class HistorialTransacciones
    {
        public int IdTransaccion { get; set; }
        public Usuario oUsuario { get; set; }
        public Libro oLibro { get; set; }
        public string TipoTransaccion { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public bool Activo { get; set; }
    }
}
