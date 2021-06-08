using System;
using Projeto_Produtos_0706.Interfaces;

namespace Projeto_Produtos_0706.Classes
{
    public class Usuario : IUsuario
    {
        private int Codigo { get; set; }

        public string Nome { get; set; }
        
        public string Email { get; set; }

        public string Senha { get; set; }

        private DateTime DataCadastro { get; set; }
        
        public int i;

        // public List<Usuario> ListaUsuario = new List<Usuario>();

        public Usuario PegarInfo()
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

        }

        public string Cadastrar(Usuario Usuario)
        {
            // ListaUsuario.Add(Usuario);
            return $"Usuario '{Usuario.Nome}' cadastrado!";
        }

        public string Deletar(Usuario Usuario)
        {
            // ListaUsuario.Remove(Usuario)
            return $"Usário '{Usuario.Nome}' removido!";
        }
    }
}