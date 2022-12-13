using System.ComponentModel.DataAnnotations;

namespace FilmesAPi.Data.Dtos
{
    public class ReadMovieDto
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int DuracaoEmMinutos { get; set; }

        public DateTime HoraDaConsulta { get; set; } = DateTime.UtcNow;
    }
}
