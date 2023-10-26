using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tabuleria_luderia.Models
{
    [Table("Lojas")]
    public class Loja
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string  NomeDaLoja { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Telefone { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Logadouro { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Cep { get; set; }


    }
}
