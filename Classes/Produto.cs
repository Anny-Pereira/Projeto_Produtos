using System;
using System.Collections.Generic;
using Projeto_Produtos_0706.Interfaces;

namespace Projeto_Produtos_0706.Classes
{
    public class Produto : IProduto
    {
        public int Codigo { get; set; }
        public bool RepDeletar = false;

        public string NomeProduto { get; set; }

        public float Preco { get; set; }

        public DateTime DataCadastro { get; set; }

       public Marca marca { get; set; } = new Marca();
       
        public Usuario CadastradoPor { get; set; } = new Usuario();
        
       public List<Produto> ListaDeProdutos { get; set; }
       

        public Produto(){}
        public Produto(int Codigo, string CadastradoPor, string NomeProduto, Marca marca){
            this.Codigo = Codigo;
            this.CadastradoPor.Nome = CadastradoPor;
            this.marca = marca;
        }
        public void PegarInfo( string nomeLogado, List<Marca> marcas){
            int i = 0;
            i++;
            Codigo = i;

            CadastradoPor.Nome = nomeLogado;
            
            Console.Write("Digite o nome do produto: ");
            NomeProduto = Console.ReadLine();

            Console.Write("Digite o preço do produto: R$ ");
            Preco = float.Parse(Console.ReadLine());
            
            
            Console.Write("Digite o nome da marca: ");
            string verificandoMarca = Console.ReadLine();
            marca = marcas.Find(item => item.NomeMarca == verificandoMarca );
            
        }
        public string Cadastrar(Produto produto)
        {
            ListaDeProdutos.Add(new Produto(Codigo, CadastradoPor.Nome, NomeProduto, marca));
            return "Produto Cadastrado !!!";
        }

        public string Deletar(Produto produto)
        {
            while (!RepDeletar)
            {
                Console.WriteLine("\nDeseja deletar algum Produto (s-sim / n-não)?");
                string RespDeletar = Console.ReadLine();

                if (RespDeletar == "s")
                {
                    RepDeletar = true;
                    Console.WriteLine("\nQual Produto deseja remover?");
                    string ProdutoDeletado = Console.ReadLine().ToLower();

                    Produto produtoEncontrado = ListaDeProdutos.Find(x => x.NomeProduto == ProdutoDeletado);

                    ListaDeProdutos.Remove(produtoEncontrado);
                }

                else if (RespDeletar == "n") 
                {
                    RepDeletar = true;
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nNenhuma opção identificada. Tente novamente!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    RepDeletar = false;
                }
            }
            return "Produto deletado !!!";
        }

        public List<Produto> Listar()
        {
            return ListaDeProdutos;
        }
    }
}