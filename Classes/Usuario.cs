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
        

        public string Cadastrar(Usuario Usuario)
        {
            throw new NotImplementedException();
        }

        public string Deletar(Usuario Usuario)
        {
            throw new NotImplementedException();
        }
    }
}