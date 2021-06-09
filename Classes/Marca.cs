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
        private string retorno;

        public Marca(string nome)
        {
            NomeMarca = nome;
        }
        public Marca() { }
        public void PegarInfo()
        {
            i++;
            Codigo = i;

            Console.Write($"Data de cadastro: {DataCadastro}");

<<<<<<< HEAD
            Console.Write($"\nCódigo da marca: {Codigo}");
=======
            Console.Write($"Código da marca: {Codigo}");
>>>>>>> 896c02180379a3516ce28486bf04572494604d2b


            Console.Write("\n\nInsira o nome da marca: ");
            NomeMarca = Console.ReadLine().ToLower();

        }


        public string Cadastrar(Marca marca)
        {
            marcas.Add(new Marca(marca.NomeMarca));

            Console.ForegroundColor = ConsoleColor.Green;
            return "\nMarca cadastrada!";
        }

        public string Deletar(Marca marca)
        {
            if (marcas.Count > 0)
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
                        if (MarcaEncontrada != null)
                        {
                            marcas.Remove(MarcaEncontrada);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            retorno = "\nMarca deletada!";
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            retorno = "\nNão é possivel deletar uma marca inexistente!";
                            Console.ForegroundColor = ConsoleColor.White;
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

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                retorno = "\nNão existem marcas cadastradas!";
                Console.ForegroundColor = ConsoleColor.White;
            }

            return retorno;
        }

        public List<Marca> Listar()
        {

            return marcas;
        }


    }
}