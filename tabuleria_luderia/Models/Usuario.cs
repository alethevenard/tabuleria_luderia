using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tabuleria_luderia.Models
{
    [Table("Usuarios")] 

    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatório informar o nome")]
        public string NomedoUsuario { get; set;}

        [Required(ErrorMessage ="Senha obrigatória")]
        [DataType(DataType.Password)] 
        public string Senha { get; set;}

        [Required(ErrorMessage = "Obrigatório informar")]
        public Perfil Perfil { get; set;}
    }

        public enum Perfil 
        {
            Admin,
            User

        }
}
