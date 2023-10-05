using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace senai.inlock.webApi_.Domains
{
    public class Usuario
    {
        [Table("Usuario")]
        [Index(nameof(Email), IsUnique = true)]
        public class Usuario
        {
            [Key]
            public Guid IdUsuario { get; set; } = Guid.NewGuid();

            [Column(TypeName = "VARCHAR(100)")]
            [Required(ErrorMessage = "Email obrigatório")]
            public string? Email { get; set; }

            [Column(TypeName = "VARCHAR(200)")]
            [Required(ErrorMessage = "Senha obrigatória!")]
            [StringLength(200, MinimumLength = 6, ErrorMessage = "Senha de 6 á 20 caracteres")]
            public string? Senha { get; set; }


            //Referência da Chave estrangeira (Tabela de TiposUsuario)

            //[Required(ErrorMessage ="Tipo do usuário obrigatório")]
            public Guid IdTipoUsuario { get; set; }


            [ForeignKey("IdTipoUsuario")]
            public TiposUsuario? TipoUsuario { get; set; }
        }
    }
}
