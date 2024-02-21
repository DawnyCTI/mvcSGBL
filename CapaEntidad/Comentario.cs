using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Comentario
    {
        public int IdComentario { get; set; }
        public Usuario oUsuario { get; set; }
        public Libro oLibro { get; set; }
        public string ComentarioText { get; set; }
        public int Calificacion { get; set; }
        public DateTime FechaComentario { get; set; }
        public bool Activo { get; set; }
        public List<Comentario> Comentarios { get; set; }
    }
}
