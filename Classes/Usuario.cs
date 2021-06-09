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

        private DateTime DataCadastro { get; set; }
        
        public int i;

        public List<Usuario> ListaUsuario = new List<Usuario>();

        // public Usuario(){

        // }
        public void PegarInfo()
        {
            i++;

            Codigo = i;
<<<<<<< HEAD
            DataCadastro = DateTime.Now;

=======
            DataCadastro = DateTime.Now;       
>>>>>>> 896c02180379a3516ce28486bf04572494604d2b
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
            Console.ForegroundColor = ConsoleColor.Green;
            return "\nUsuário cadastrado!";
        }

        public string Deletar(Usuario usuario)
        {
            ListaUsuario.Remove(usuario);
            Console.ForegroundColor = ConsoleColor.Cyan;
            return $"Usário '{usuario.Nome}' removido!";
        }

        public List<Usuario> RetornarLista(){

            return ListaUsuario;
        }
    }
}