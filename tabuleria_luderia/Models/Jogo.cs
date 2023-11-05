using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace tabuleria_luderia.Models
{
   
    [Table("Jogos")]
    public class Jogo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Nome do Jogo")]
        public string NomeDoJogo { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Mínimo de Jogadores")]
        public string MinJogadores { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Máximo de jogadores")]
        public string MaxJogadores { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Idade mínima")]
        public string IdadeMin { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Mecânicas")]
        public string Mecanicas { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Temas { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public decimal Valor { get; set; }

        [Display(Name = "Loja")]
        [Required(ErrorMessage = "Obrigatório informar o nome da loja")]
        public int LojaId { get; set; }

        [ForeignKey("LojaId")]
        public Loja Loja { get; set; }
    }
}

