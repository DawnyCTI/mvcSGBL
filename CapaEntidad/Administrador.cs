using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Administrador
    {
        public int IdAdministrador { get; set; }
        public Usuario oUsuario { get; set; }
        public bool Activo { get; set; }
    }
}
