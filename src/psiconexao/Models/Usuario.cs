
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace psiconexao.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o contato")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Obrigatório informar uma senha")]
        public string Password { get; set; }
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Admin,
        Psicologo,
        Paciente
    }

}