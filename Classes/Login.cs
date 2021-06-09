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
            Console.ForegroundColor = ConsoleColor.Green;
            return "\nVocê deslogou com sucesso!";
        }

        public string Logar(Usuario usuario)
        {
            string retorno;

            Console.Write("\nDigite seu usuário: ");

            usuarioLogin = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            string senhaLogin = Console.ReadLine();

            List<Usuario> verificarUsuario = usuario.RetornarLista() ;

            Usuario userEncontrado = verificarUsuario.Find(x => x.Nome == usuarioLogin && x.Senha == senhaLogin);

            if (userEncontrado != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                retorno = "\nUsuário logado com sucesso!";
                Console.ForegroundColor = ConsoleColor.White;
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
            //List<Marca> marcas = new List<Marca>();

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($@"
    =================================
    |            Menu:              |
    ---------------------------------
    |    [1] Cadastrar Usuario      |
    |    [2] Fazer Login            |
    |    [3] Deletar Usuario        |
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
    |    [7] - Deslogar                         |
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
                                            if (marca.marcas.Count > 0)
                                            {
                                                marca.Listar();
                                                cont = 0;
                                                foreach (var M in marca.marcas)
                                                {
                                                    cont++;
                                                    Console.WriteLine($"{cont} - {M.NomeMarca}");
                                                }
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\nNão há nehuma marca cadastrada para listar!");
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            break;
                                        case "3":
                                            Console.WriteLine(marca.Deletar(marca));
                                            break;
                                        case "4":
                                            Produto p = new Produto(IDproduto, usuario, marca.Listar());
                                            if (produto.Cadastrar(p, marca.Listar(), IDproduto) == "\n Produto Cadastrado!") 
                                            {
                                                Console.ForegroundColor = ConsoleColor.Green;
                                                Console.WriteLine("Produto cadastrado com sucesso!");
                                                IDproduto++;
                                                Console.ResetColor();
                                            } else
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("Houve um erro e o produto não foi cadastrado, é necessario cadastrar uma marca antes de cadastrar um produto");
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            break;
                                        case "5":
                                            produto.Listar();

                                            break;
                                        case "6":
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine(produto.Deletar(produto));
                                            Console.ResetColor();
                                            break;
                                        case "7":
                                            sair = true;
                                            verificandoCadastro = false;
                                            Console.WriteLine(Deslogar(usuario));

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
                    case "3":
                        Console.Write("Digite o usuario que deseja apagar: ");
                        string UsuarioApagar = Console.ReadLine();
                        List<Usuario> procurarUsuario = usuario.RetornarLista() ;
                        if (procurarUsuario.Count > 0)
                        {
                            Usuario temp = procurarUsuario.Find(item => item.Nome == UsuarioApagar);
                            if (temp != null)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine(usuario.Deletar(temp));
                                Console.ResetColor();
                                sair = true;
                            }
                            else
                            {
                                Console.WriteLine("Esse usuario não existe!!!");
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
