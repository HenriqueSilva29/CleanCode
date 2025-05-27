using System.ComponentModel.DataAnnotations;

namespace backend.Core.Entities
{
    /// <summary>
    /// Representa um usuário autenticado da plataforma.
    /// </summary>
    public class Usuario
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Necessário informar um nome de usuário.")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Necessário informar uma senha.")]
        public string Senha { get; set; } = string.Empty;

        [Required(ErrorMessage = "Necessário informar um e-mail.")]
        public string Email { get; set; } = string.Empty;
    }
}
