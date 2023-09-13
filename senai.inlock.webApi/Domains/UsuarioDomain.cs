using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace senai.inlock.webApi_.Domains
{
    public class UsuarioDomain
    {
        public int IdUsuario { get; set; }
        [Required(ErrorMessage = "O campo é obrigatorio")]

        public int IdTipoUsuario { get; set; }

        public string Email { get; set; }
        [StringLength(18, MinimumLength = 3, ErrorMessage = "A senha deve conter de 3 a 18 caracteres")]
        [Required(ErrorMessage = "A Senha é Obrigatoria ! ")]
        public string Senha { get; set; }
        public ClaimsIdentity? TipoUsuario { get; internal set; }
    }
}
