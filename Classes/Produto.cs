using System;
using System.Collections.Generic;
using Projeto_Produtos_0706.Interfaces;

namespace Projeto_Produtos_0706.Classes
{
    public class Produto : IProduto
    {
        private int Codigo { get; set; }

        private string NomeProduto { get; set; }

        private float Preco { get; set; }

        private DateTime DataCadastro { get; set; }

       private Marca Marca { get; set; }
       
        private Usuario CadastradoPor { get; set; }
        
       private List<Produto> ListaDeProdutos { get; set; }
       

        public string Cadastrar(Produto Produto)
        {
            throw new NotImplementedException();
        }

        public string Deletar(Produto Produto)
        {
            throw new NotImplementedException();
        }

        public List<Produto> Listar()
        {
            throw new NotImplementedException();
        }
    }
}