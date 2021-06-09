using System;
using System.Collections.Generic;
using Projeto_Produtos_0706.Interfaces;

namespace Projeto_Produtos_0706.Classes
{
    public class Usuario : IUsuario
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }
        
        public string Email { get; set; }

        public string Senha { get; set; }

        private DateTime DataCadastro = DateTime.Now;
        
        public int i;

        public List<Usuario> ListaUsuario = new List<Usuario>();

        public Usuario()
        {
            i++;

            Codigo = i;

            Console.Write($"\nData de cadastro: {DataCadastro}");
            
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
            return "\nUsuario cadastrado!\n";
        }

        public string Deletar(Usuario usuario)
        {
            ListaUsuario.Remove(usuario);
            return $"\nUsário '{usuario.Nome}' removido!\n";
        }
    }
}