using System;
using Projeto_Produtos_0706.Interfaces;

namespace Projeto_Produtos_0706.Classes
{
    public class Usuario : IUsuario
    {
        private int Codigo { get; set; }

        public string Nome { get; private set; }
        
        private string Email { get; set; }

        public string Senha { get; private set; }

        private DateTime DataCadastro { get; set; }
        
        public int i;

        public string Cadastrar(string usuario)
        {
            i++;
            
            Codigo = i;

            Console.Write($"Data de cadastro: {DataCadastro}");
            
            Console.Write("\nInsira seu nome: ");
            Nome = Console.ReadLine();

            Console.Write("Insira seu e-mail: ");
            Email = Console.ReadLine();

            Console.Write("Insira sua senha: ");
            Senha = Console.ReadLine();

            return "Usuario cadastrado!";
        }

        public string Deletar(Usuario Usuario)
        {
            return $"Usuario '{Nome}' removido!";
        }
    }
}