using senai.inlock.webApi_.Domains;

namespace senai.inlock.webApi_.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario BuscarUsuario(string email, string senha);

        void Cadastrar(Usuario usuario);
    }
}
