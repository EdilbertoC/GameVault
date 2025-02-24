using GameVault.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace GameVault.Models
{
    public class Jogo
    {
        [Key]
        public int JogoId { get; set; }

        [Required(ErrorMessage = "O nome do jogo deve ser informado")]
        [Display(Name = "Nome do Jogo")]
        [StringLength(80, MinimumLength = 4, ErrorMessage = "O {0} deve ter no mínimo {2} e no máximo {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do jogo deve ser informada")]
        [Display(Name = "Descrição do Jogo")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "A plataforma do jogo deve ser informada")]
        [Display(Name = "Plataforma do Jogo")]
        [StringLength(80, MinimumLength = 1, ErrorMessage = "A {0} deve ter no mínimo {2} e no máximo {1} caracteres")]
        public string Plataforma { get; set; }

        [Required(ErrorMessage = "Os gêneros do jogo devem ser informados")]
        [Display(Name = "Gêneros do Jogo")]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "O {0} deve ter no mínimo {2} e no máximo {1} caracteres")]
        public string Generos { get; set; }
        public int ReviewId { get; set; }
        public Review Review { get; set; }
    }
}
