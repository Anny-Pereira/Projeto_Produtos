using System;
using Projeto_Produtos_0706.Interfaces;

namespace Projeto_Produtos_0706.Classes
{
    public class Usuario : IUsuario
    {
        private int Codigo { get; set; }

        private string Nome { get; set; }
        
        private string Email { get; set; }

        private string Senha { get; set; }

        private DateTime DataCadastro { get; set; }
        
        public int i;

        public string Cadastrar(Usuario Usuario)
        {
            i++;

            Usuario.Codigo = i;

            Console.Write($"Data de cadastro: {DataCadastro}");
            
            Console.Write("\nInsira seu nome: ");
            Usuario.Nome = Console.ReadLine();

            Console.Write("Insira seu e-mail: ");
            Usuario.Email = Console.ReadLine();

            Console.Write("Insira sua senha: ");
            Usuario.Email = Console.ReadLine();

            return "Usuario cadastrado!";
        }

        public string Deletar(Usuario Usuario)
        {
            return $"Usário '{Usuario.Nome}' removido!";
        }
    }
}