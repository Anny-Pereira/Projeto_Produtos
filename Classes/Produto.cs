using System;
using System.Collections.Generic;
using Projeto_Produtos_0706.Interfaces;

namespace Projeto_Produtos_0706.Classes
{
    public class Produto : IProduto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public Marca marca { get; set; }
        public Usuario CadastradoPor { get; set; }
        List<Produto> ListaDeProdutos = new List<Produto>();
        public bool RepDeletar = false;
        public string retorno = "";

        public Produto(){}

        public Produto(int IDcodigo, Usuario usuario, List<Marca> listaMarcas)
        {
            Codigo = IDcodigo;
            DataCadastro = DateTime.Now;
            Console.Write("\n Digite o nome do produto: ");
            NomeProduto = Console.ReadLine();
            Console.Write("Digite o preço do produto: R$");
            Preco = float.Parse(Console.ReadLine());

            CadastradoPor = usuario;
            Console.Write("Digite o nome da marca: ");
            string VerificandoMarca = Console.ReadLine();
            marca = listaMarcas.Find(item => item.NomeMarca == VerificandoMarca);
            
        }

        public string Cadastrar(Produto produto, List<Marca> listaMarcas, int IDproduto)
        {

            {
                if (listaMarcas.Count > 0 && produto.marca != null)
                {
                    ListaDeProdutos.Add(produto);
                    IDproduto++;
                    return "\n Produto Cadastrado!";
                }

                else
                {
                    return "Não foi possivel cadastrar pois a marca é inexistente";
                }
            }
        }

        public string Deletar(Produto produto)
        {
            if (ListaDeProdutos.Count > 0)
            {
                while (!RepDeletar)
                {
                    Console.WriteLine("\nDeseja deletar algum item (s-sim / n-não)?");
                    string RespDeletar = Console.ReadLine();

                    if (RespDeletar == "s")
                    {
                        RepDeletar = true;
                        Console.WriteLine("\nQual produto deseja remover?");
                        string produtoDeletado = Console.ReadLine();

                        Produto produtoEncontrado = ListaDeProdutos.Find(x => x.NomeProduto == produtoDeletado);
                        if (produtoEncontrado != null)
                        {
                            ListaDeProdutos.Remove(produtoEncontrado);
                            retorno = "Produto deletado!";
                        }
                        else
                        {
                            retorno = "Não é possivel deletar uma produto inexistente";
                        }
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
                
            } else{
                retorno = "Não existem produtos cadastradas";
            }

            return retorno;
        }

        public void Listar()
        {
            Console.WriteLine("\n Produtos cadastrados: ");

            if (ListaDeProdutos.Count > 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                foreach (Produto item in ListaDeProdutos)
                {
                    Console.WriteLine($@"
Cadastrado Por: {item.CadastradoPor.Nome}
Código: {item.Codigo}
Nome do produto: {item.NomeProduto}
Preço: {item.Preco:C2}
Data de cadastro: {item.DataCadastro}
Marca: {item.marca.NomeMarca}");
                }
            }

            else
            {
                Console.WriteLine("\n A lista está vazia!!!");
            }

            Console.ResetColor();
        }

        public List<Produto> ListarExistentes()
        {
            return ListaDeProdutos;
        }
    }
}