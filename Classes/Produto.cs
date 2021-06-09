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

        public Produto(){}

        public Produto(int IDcodigo, Usuario usuario, List<Marca> listaMarcas)
        {
            Codigo = IDcodigo;
            DataCadastro = DateTime.Now;
            Console.Write("\nDigite o nome do produto: ");
            NomeProduto = Console.ReadLine();
            Console.Write("\nDigite o preço do produto: R$ ");
            Preco = float.Parse(Console.ReadLine());

            CadastradoPor = usuario;
            Console.Write("\nDigite o nome da marca: ");
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
                    return "\nProduto Cadastrado!";
                }

                else
                {
                    return "\nNão foi possivel cadastrar pois a marca é inexistente!";
                }
            }
        }

        public string Deletar(Produto produto)
        {
            ListaDeProdutos.Remove(produto);
            return "\n Produto deletado!";
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nA lista está vazia!");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.ResetColor();
        }

        public List<Produto> ListarExistentes()
        {
            return ListaDeProdutos;
        }
    }
}