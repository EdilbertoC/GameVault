using System.ComponentModel.DataAnnotations;

namespace GameVault.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required(ErrorMessage = "O comentário da review deve ser informado")]
        [Display(Name = "Comentário da Review")]
        [MinLength(20, ErrorMessage = "O comentário deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "O comentário não pode exceder {1} caracteres")]
        public string Comentario { get; set; }

        [Required(ErrorMessage = "Informe a nota da review")]
        [Display(Name = "Nota")]
        [Range(1, 10, ErrorMessage = "A nota deve estar entre 1 e 10")]
        public int Nota { get; set; }

        [Display(Name = "Data da Review")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime DataAvaliacao { get; set; }

        [Required(ErrorMessage = "Informe o tempo de jogo")]
        [Display(Name = "Tempo de Preparo")]
        [DisplayFormat(DataFormatString = @"{0:hh\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan TempoDeJogo { get; set; }
        public int JogoId { get; set; }
        public Jogo Jogo { get; set; }
    }
}
