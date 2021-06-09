using System;
using Projeto_Produtos_0706.Interfaces;
using System.Collections.Generic;

namespace Projeto_Produtos_0706.Classes
{
    public class Login : ILogin
    {
        private bool Logado { get; set; } = false;
        public string usuarioLogin;

        public string Deslogar(Usuario usuario)
        {
            Logado = false;
            return "\nVocê deslogou com sucesso!";
        }

        public string Logar(Usuario usuario)
        {
            string retorno;

            Console.Write("\nDigite seu usuário: ");

            usuarioLogin = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            string senhaLogin = Console.ReadLine();

            if (usuarioLogin == usuario.Nome && senhaLogin == usuario.Senha)
            {
                retorno = "\nUsuário logado com sucesso!";
                Logado = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                retorno = "\nAlgo deu errado. Verifique as informações digitadas!";
                Console.ForegroundColor = ConsoleColor.White;
                Logado = false;
            }
            return retorno;
        }

        public Login()
        {
            string opcao1;
            string opcao2;
            int cont = 0;
            int IDproduto = 1;
            bool verificandoCadastro = false;
            Usuario usuario = new Usuario();
            Marca marca = new Marca();
            Produto produto = new Produto();
            bool sair = false;
            
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($@"
    =================================
    |            Menu:              |
    ---------------------------------
    |    [1] Cadastrar Usuario      |
    |    [2] Fazer Login            |
    =================================
             ");
                Console.ForegroundColor = ConsoleColor.White;
                opcao1 = Console.ReadLine();
                switch (opcao1)
                {
                    case "1":
                        usuario.PegarInfo();
                        Console.WriteLine(usuario.Cadastrar(usuario));
                        verificandoCadastro = true;
                        break;
                    case "2":

                        if (verificandoCadastro == true)
                        {
                            Console.WriteLine(Logar(usuario));
                            if (Logado == true)
                            {
                                do
                                {
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine($@"
    =============================================
    |                   MENU:                   |
    ---------------------------------------------
    |    [1] - Cadastrar Marcas                 |
    |    [2] - Listar as Marcas cadastradas     |
    |    [3] - Deletar Marca                    |
    |    [4] - Cadastrar produto                |
    |    [5] - Listar produtos cadastrados      |
    |    [6] - Deletar produtos                 |
    |    [7] - Sair                             |
    =============================================
         ");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    opcao2 = Console.ReadLine();
                                    switch (opcao2)
                                    {
                                        case "1":
                                            marca.PegarInfo();
                                            Console.WriteLine(marca.Cadastrar(marca));
                                            break;
                                        case "2":
                                            marca.Listar();
                                            cont = 0;
                                            foreach (var M in marca.marcas)
                                            {
                                                cont++;
                                                Console.WriteLine($"{cont} \n {M.NomeMarca}");
                                            }
                                            break;
                                        case "3":
                                            Console.WriteLine(marca.Deletar(marca));
                                            break;
                                        case "4":
                                            Produto p = new Produto(IDproduto, usuario, marca.Listar());
                                            if (produto.Cadastrar(p, marca.Listar(), IDproduto) == "\n Produto Cadastrado!") //Cria um produto e verifica se a marca existe
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Produto cadastrado com sucesso!");
                                                IDproduto++;
                                                Console.ResetColor();
                                            }
                                            break;
                                        case "5":
                                            produto.Listar();

                                            break;
                                        case "6":
                                            Console.Write("Digite o produto que deseja apagar: ");
                                            string produtoApagar = Console.ReadLine();
                                            List<Produto> procurarProdutos = produto.ListarExistentes();

                                            Produto existe = procurarProdutos.Find(item => item.NomeProduto == produtoApagar);

                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(produto.Deletar(existe));
                                            Console.ResetColor();
                                            break;
                                        case "7":
                                            sair = true;
                                            verificandoCadastro = false;
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            Console.WriteLine("\nVocê saiu com sucesso!\n");
                                            Console.ForegroundColor = ConsoleColor.White;

                                            break;
                                        default:
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\nO valor digitado é inválido!\n");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            break;
                                    }


                                } while (sair == false);

                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNenhum usuário foi cadastrado!\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            sair = false;
                        }
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nO valor digitado é inválido!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        sair = false;
                        break;


                }
            } while (verificandoCadastro == true || sair == false);

        } //fim da funcao
    }

}
