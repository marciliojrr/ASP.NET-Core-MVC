using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; } // Exigido pelo BD, para chave-primaria (PK).
        public string? Title { get; set; }

        [DataType(DataType.Date)] // O usuário não é solicitado a inserir informações de hora no campo de data.
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public decimal Price { get; set; }
    }
}
