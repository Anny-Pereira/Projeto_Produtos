using System;
using Projeto_Produtos_0706.Interfaces;

namespace Projeto_Produtos_0706.Classes
{
    public class Usuario : IUsuario
    {
                public int Codigo { get; set; }

        public string Nome { get; set; }
        
        public string Email { get; set; }

        public string Senha { get; set; }

        private DateTime DataCadastro { get; set; }
        
        public int i;

        public List<Usuario> ListaUsuario = new List<Usuario>();

        public Usuario()
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

        }

        public string Cadastrar(Usuario usuario)
        {
            ListaUsuario.Add(usuario);

            return "Usuario cadastrado!";
        }

        public string Deletar(Usuario usuario)
        {
            ListaUsuario.Remove(usuario);
            return $"Usário '{usuario.Nome}' removido!";
        }
    }
}