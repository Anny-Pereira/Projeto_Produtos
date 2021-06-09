using System;
using Projeto_Produtos_0706.Interfaces;

namespace Projeto_Produtos_0706.Classes
{
    public class Login : Usuario, ILogin
    {
        private bool Logado { get; set; } = false;
    
        public string Deslogar(Usuario Usuario)
        {
            Logado = false;
            return "Você deslogou com sucesso!!!";
        }

        public string Logar(Usuario Usuario)
        {
            string retorno;

            Console.Write("Digite seu usuario: ");
            string usuarioLogin = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            string senhaLogin = Console.ReadLine();

            if (usuarioLogin == Usuario.Nome && senhaLogin == Usuario.Senha)
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