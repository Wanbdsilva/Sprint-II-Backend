using senai.inlock.webApi_.Domains;
using senai.inlock.webApi_.Interfaces;
using System.Data.SqlClient;

namespace senai.inlock.webApi_.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private string StringConexao = "Data Source =NOTE18-S15; Initial catalog =inlock_games; User id = sa; pwd = Senai@134";

        private readonly InlockContext ctx;

        /// <summary>
        /// Construtor do repositório
        /// Toda vez que o repositório for instanciado,
        /// Ele terá acesso aos dados fornecidos pelo contexto
        /// </summary>
        public UsuarioRepository()
        {
            ctx = new InlockContext();
        }

        public Usuario BuscarUsuario(string email, string senha)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            try
            {

                usuario.Senha = Criptografia.GerarHash(usuario.Senha!);


                ctx.Usuario.Add(usuario);


                ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
