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

<<<<<<< HEAD
        public DateTime DataCadastro { get; set; }
=======
        private DateTime DataCadastro = DateTime.Now;
>>>>>>> a7703a488f6a5458e3d80c2293e347337e4c204f

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
<<<<<<< HEAD
            Codigo = i;

            CadastradoPor.Nome = nomeLogado;
            
            Console.Write("Digite o nome do produto: ");
=======
            
            Console.Write("\nDigite o nome do produto: ");
>>>>>>> a7703a488f6a5458e3d80c2293e347337e4c204f
            NomeProduto = Console.ReadLine();

            Console.Write("\nDigite o preço do produto: R$ ");
            Preco = float.Parse(Console.ReadLine());
            
            
            Console.Write("\nDigite o nome da marca: ");
            string verificandoMarca = Console.ReadLine();
            marca = marcas.Find(item => item.NomeMarca == verificandoMarca );
            
        }
        public string Cadastrar(Produto produto)
        {
<<<<<<< HEAD
            ListaDeProdutos.Add(new Produto(Codigo, CadastradoPor.Nome, NomeProduto, marca));
            return "Produto Cadastrado !!!";
=======
            ListaDeProdutos.Add(produto);
            return "\nProduto Cadastrado!\n";
>>>>>>> a7703a488f6a5458e3d80c2293e347337e4c204f
        }

        public string Deletar(Produto produto)
        {
<<<<<<< HEAD
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
=======
            ListaDeProdutos.Remove(produto);
            return "\nProduto deletado!\n";
>>>>>>> a7703a488f6a5458e3d80c2293e347337e4c204f
        }

        public List<Produto> Listar()
        {
            return ListaDeProdutos;
        }
    }
}