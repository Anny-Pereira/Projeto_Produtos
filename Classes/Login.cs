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
            bool verificandoCadastro = false;
            Usuario usuario = new Usuario();
            Marca marca = new Marca();
            Produto produto = new Produto();
            bool sair = false;
            List<Marca> marcas = new List<Marca>();
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
                                            produto.PegarInfo(usuarioLogin, marca.marcas);
                                            Console.WriteLine(produto.Cadastrar(produto));
                                            break;
                                        case "5":
                                            produto.Listar();
                                            foreach (var P in produto.ListaDeProdutos)
                                            {
                                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                                Console.WriteLine($@"
    ====================================================
    |    Adicionado por {P.CadastradoPor.Nome}
    |    Id: {P.Codigo}
    |    Nome do produto: {P.NomeProduto}
    |    Preço: {P.Preco:C2}
    |    Marca: {P.marca.NomeMarca}
    ====================================================
");
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            break;
                                        case "6":
                                            Console.WriteLine(produto.Deletar(produto));
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
