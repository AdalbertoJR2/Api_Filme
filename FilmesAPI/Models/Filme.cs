using System;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Título é Obrigatório.")]
        public string Titulo { get; set; }
        
        [Required(ErrorMessage = "O campo Diretor é Obrigatório.")]
        public string Diretor { get; set; }
        
        [StringLength(20, ErrorMessage = "O campo Genero não pode ter mais que 20 caracteres.")]
        public string Genero { get; set; }
        
        [Range(1, 600, ErrorMessage = "A duração deve ser de 1 á 300 minutos.")]
        public int Duracao { get; set; }
    }
}
