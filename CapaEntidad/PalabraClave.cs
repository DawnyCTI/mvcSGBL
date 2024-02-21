using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class PalabraClave
    {
        public int IdPalabraClave { get; set; }
        public string Palabra { get; set; }
        public bool Activo { get; set; }
    }
}
