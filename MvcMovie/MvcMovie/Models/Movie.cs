using System;
using System.ComponentModel.DataAnnotations; // Necessario para que possamos usar DataAnnotations
using System.ComponentModel.DataAnnotations.Schema; // DataAnnotations permitem alterar a exibicao de alguns itens


namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; } // Exigido pelo BD, para chave-primaria (PK).
        public string? Title { get; set; }

        [Display(Name = "Release Date")] // O atributo Display especifica o que deve ser exibido no nome de um campo (neste caso, “Release Date” em vez de “ReleaseDate”). 
        [DataType(DataType.Date)] // O usuário não é solicitado a inserir informações de hora no campo de data.
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }

        [Column(TypeName = "decimal(18, 2)")] // Necessário para que o Entity Framework Core possa mapear corretamente o Price para a moeda no banco de dados.
        public decimal Price { get; set; }
    }
}
