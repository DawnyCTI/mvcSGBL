using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Restablecer { get; set; }    
        public string TipoUsuario { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }

        public List<Prestamo> Prestamos { get; set; }

        // Lista de reservas de libros
        public List<Reserva> Reservas { get; set; }

        // Lista de comentarios de los usuarios sobre los libros
        public List<Comentario> Comentarios { get; set; }

        // Lista de notificaciones para los usuarios
        public List<Notificacion> Notificaciones { get; set; }

    }
}
