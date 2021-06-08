using System;
using Projeto_Produtos_0706.Interfaces;

namespace Projeto_Produtos_0706.Classes
{
    public class Login : ILogin
    {
        private bool Logado { get; set; } = false;
        public string usuarioLogin;
    
        public string Deslogar(Usuario usuario)
        {
            Logado = false;
            return "Você deslogou com sucesso!!!";
        }

        public string Logar(Usuario usuario)
        {
            string retorno;

            Console.Write("Digite seu usuario: ");
            
            usuarioLogin = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            string senhaLogin = Console.ReadLine();

            if (usuarioLogin == usuario.Nome && senhaLogin == usuario.Senha)
            {
                retorno = "Usuario Logado com sucesso!!!";
                Logado = true;
            }
            else
            {
                retorno = "Algo deu errado verifique as informações digitadas";
            }
            return retorno;
        }

        public Login()
        {
            if (Logado == true)
            {
                int opcao;
                Console.Write("Opções e tals");
                opcao = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Algo deu errado :(");
            }
        }
    }
}