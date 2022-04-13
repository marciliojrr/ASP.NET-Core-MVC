using System;
using System.ComponentModel.DataAnnotations; // Necessario para que possamos usar DataAnnotations
using System.ComponentModel.DataAnnotations.Schema; // DataAnnotations permitem alterar a exibicao de alguns itens


namespace MvcMovie.Models
{
    public class Movie
    {
        /*
         * Os atributos de validação [DataAnnotations] especificam o 
         * comportamento que você deseja impor nas 
         * propriedades de modelo às quais eles são aplicados.
         */
        public int Id { get; set; } // Exigido pelo BD, para chave-primaria (PK).
        //

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }

        //

        [Display(Name = "Release Date")] // O atributo Display especifica o que deve ser exibido no nome de um campo (neste caso, “Release Date” em vez de “ReleaseDate”). 
        [DataType(DataType.Date)] // O usuário não é solicitado a inserir informações de hora no campo de data.
        public DateTime ReleaseDate { get; set; }

        //

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(30)]
        public string? Genre { get; set; }

        //

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")] // Necessário para que o Entity Framework Core possa mapear corretamente o Price para a moeda no banco de dados.
        public decimal Price { get; set; }

        //

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string? Rating { get; set; }
    }
}
