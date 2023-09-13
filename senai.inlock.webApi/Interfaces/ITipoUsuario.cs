using senai.inlock.webApi_.Domains;

namespace senai.inlock.webApi_.Interfaces
{
    public interface ITipoUsuario
    {
        UsuarioDomain Logar(string Administrador, string UsuarioComun);
    }
}
