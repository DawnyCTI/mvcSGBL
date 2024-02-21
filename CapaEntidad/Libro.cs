using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public string PalabrasClave { get; set; }
        public string Sinopsis { get; set; }
        public bool Disponibilidad { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }

        // Lista de préstamos de libros
        public List<Prestamo> Prestamos { get; set; }

        // Lista de reservas de libros
        public List<Reserva> Reservas { get; set; }

        // Lista de comentarios de los usuarios sobre los libros
        public List<Comentario> Comentarios { get; set; }
    }
}
