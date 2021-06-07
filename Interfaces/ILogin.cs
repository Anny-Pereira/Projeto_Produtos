using Projeto_Produtos_0706.Classes;

namespace Projeto_Produtos_0706.Interfaces
{
    public interface ILogin
    {
        public void Login();

        public string Logar(Usuario Usuario);

        public string Deslogar(Usuario Usuario);
    }
}