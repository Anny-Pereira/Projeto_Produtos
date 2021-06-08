using Projeto_Produtos_0706.Classes;

namespace Projeto_Produtos_0706.Interfaces
{
    public interface IUsuario
    {
        public string Cadastrar(string usuario);

        public string Deletar(Usuario Usuario);
    }
}