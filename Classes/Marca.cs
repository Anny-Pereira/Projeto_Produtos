using System;
using System.Collections.Generic;
using Projeto_Produtos_0706.Interfaces;

namespace Projeto_Produtos_0706.Classes
{
    public class Marca : IMarca
    {
        private int Codigo { get; set; }

        private string NomeMarca { get; set; }

        private DateTime DataCadastro { get; set; }

        public int i;

        private bool RepDeletar = false;

        List<Marca> marcas = new List<Marca>();

        public string Cadastrar(Marca Marca)
        {
            Marca marca = new Marca();

            i++;
            marca.Codigo = i;

            Console.Write($"Data de cadastro: {DataCadastro}");

            Console.Write($"Código da marca: {marca.Codigo}");


            Console.Write("\nInsira o nome da marca: ");
            marca.NomeMarca = Console.ReadLine();


            marcas.Add(marca);

            return "Marca cadastrada!";
        }

        public string Deletar(Marca Marca)
        {
            while (!RepDeletar)
            {
                Console.WriteLine("\nDeseja deletar algum item (s-sim / n-não)?");
                string RespDeletar = Console.ReadLine();

                if (RespDeletar == "s")
                {
                    RepDeletar = true;
                    Console.WriteLine("\nQual marca deseja remover?");
                    string MarcaDeletada = Console.ReadLine().ToLower();

                    Marca MarcaEncontrada = marcas.Find(x => x.NomeMarca == MarcaDeletada);

                    marcas.Remove(MarcaEncontrada);
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

            return "Marca deletada!";
        }

        public List<Marca> Listar()
        {
            foreach (var M in marcas)
            {
                Console.WriteLine($@"
    {M.DataCadastro}
    {M.Codigo}
    {M.NomeMarca}
                ");
            }

            return marcas;
        }
    }
}