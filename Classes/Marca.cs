using System;
using System.Collections.Generic;
using Projeto_Produtos_0706.Interfaces;

namespace Projeto_Produtos_0706.Classes
{
    public class Marca : IMarca
    {
        public int Codigo { get; set; }

        public string NomeMarca { get; set; }

        public DateTime DataCadastro = DateTime.Now;

        public int i;

        public bool RepDeletar = false;

        public List<Marca> marcas = new List<Marca>();


        public Marca(string nome){
            NomeMarca = nome;
        }
        public Marca(){}
        public void PegarInfo()
        {
            i++;
            Codigo = i;

            Console.Write($"\nData de cadastro: {DataCadastro}");

            Console.Write($"Código da marca: {Codigo}");


            Console.Write("\nInsira o nome da marca: ");
            NomeMarca = Console.ReadLine();

        }
        

        public string Cadastrar(Marca marca)
        {
            marcas.Add(new Marca(marca.NomeMarca));

            return "\nMarca cadastrada!\n";
        }

        public string Deletar(Marca marca)
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
            
            return marcas;
        }

    }
}