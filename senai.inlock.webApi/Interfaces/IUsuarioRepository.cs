using senai.inlock.webApi_.Domains;

namespace senai.inlock.webApi_.Interfaces
{
    public interface IUsuarioRepository
    {
        UsuarioDomain Logar(String Email, string Senha);
    }
}
