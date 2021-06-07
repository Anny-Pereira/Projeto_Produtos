using Projeto_Produtos_0706.Interfaces;

namespace Projeto_Produtos_0706.Classes
{
    public class Login : ILogin
    {
        private bool Logado { get; set; }
        

        public string Deslogar(Usuario Usuario)
        {
            throw new System.NotImplementedException();
        }

        public string Logar(Usuario Usuario)
        {
            throw new System.NotImplementedException();
        }

        void ILogin.Login()
        {
            throw new System.NotImplementedException();
        }
    }
}