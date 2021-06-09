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

        private DateTime DataCadastro = DateTime.Now;

       private Marca Marca { get; set; }
       
        private Usuario CadastradoPor { get; set; }
        
       private List<Produto> ListaDeProdutos { get; set; }
       

        public Produto( string nomeLogado, List<Marca> marcas, List<Usuario> ListaUsuarios){
            int i = 0;
            i++;
            
            Console.Write("\nDigite o nome do produto: ");
            NomeProduto = Console.ReadLine();

            Console.Write("\nDigite o preço do produto: R$ ");
            Preco = float.Parse(Console.ReadLine());

            
            CadastradoPor = ListaUsuarios.Find(item => item.Nome == nomeLogado);
            
            Console.Write("\nDigite o nome da marca: ");
            string verificandoMarca = Console.ReadLine();
            Marca = marcas.Find(item => item.NomeMarca == verificandoMarca );
        }
        public string Cadastrar(Produto produto)
        {
            ListaDeProdutos.Add(produto);
            return "\nProduto Cadastrado!\n";
        }

        public string Deletar(Produto produto)
        {
            ListaDeProdutos.Remove(produto);
            return "\nProduto deletado!\n";
        }

        public List<Produto> Listar()
        {
            return ListaDeProdutos;
        }
    }
}