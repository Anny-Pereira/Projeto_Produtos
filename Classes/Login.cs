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
            return "Você deslogou com sucesso!!!";
        }

        public string Logar(Usuario usuario)
        {
            string retorno;

            Console.Write("Digite seu usuario: ");
            
            usuarioLogin = Console.ReadLine();

            Console.Write("Digite sua senha: ");
            string senhaLogin = Console.ReadLine();

            if (usuarioLogin == usuario.Nome && senhaLogin == usuario.Senha)
            {
                retorno = "Usuario Logado com sucesso!!!";
                Logado = true;
            }
            else
            {
                retorno = "Algo deu errado verifique as informações digitadas";
                Logado = false;
            }
            return retorno;
        }

        public Login()
        {
            int opcao1;
            int opcao2;
            int cont = 0;
            bool verificandoCadastro = false;
            Usuario usuario = new Usuario(); 
            Marca marca = new Marca();
            Produto produto = new Produto();
            bool sair = false;
            List<Marca> marcas = new List<Marca>();
            do
            {
                Console.Write($@"
    Menu:

[1] Cadastrar Usuario
[2] Fazer Login  

R: ");
                opcao1 = int.Parse(Console.ReadLine());
                switch (opcao1)
                {
                    case 1:
                        usuario.PegarInfo();
                        Console.WriteLine(usuario.Cadastrar(usuario));
                        verificandoCadastro = true;
                        break;
                    case 2:
                    
                        if ( verificandoCadastro == true )
                        {
                            Console.WriteLine(Logar(usuario));
                            if (Logado == true)
                            {
                                do
                                {
                                    
                                    Console.Write($@"
                MENU:

        [1] - Cadastrar Marcas
        [2] - Listar as Marcas cadastradas
        [3] - Deletar Marca
        [4] - Cadastrar produto
        [5] - Listar produtos cadastrados
        [6] - Deletar produtos
        [7] - Sair
        
        R: ");  
                                    opcao2 = int.Parse(Console.ReadLine());
                                    switch (opcao2)
                                    {
                                        case 1:
                                            marca.PegarInfo();
                                            Console.WriteLine(marca.Cadastrar(marca));
                                            break;
                                        case 2:
                                            marca.Listar();
                                            foreach (var M in marca.marcas){
                                                cont++;
                                                Console.WriteLine($"{cont} - {M.NomeMarca}");
                                            }
                                            break;
                                        case 3:
                                            marca.Deletar(marca);
                                            break;
                                        case 4:
                                            produto.PegarInfo(usuarioLogin, marca.marcas);
                                            Console.WriteLine(produto.Cadastrar(produto));
                                            break;
                                        case 5:
                                            produto.Listar();
                                            foreach (var P in produto.ListaDeProdutos){
                                                Console.WriteLine($@"
Adicionado por {P.CadastradoPor.Nome}
Id: {P.Codigo}
Nome do produto: {P.NomeProduto}
Preço: {P.Preco:C2}
Marca: {P.marca.NomeMarca}
");
                                            }
                                            break;
                                        case 6:
                                            break;
                                        case 7:
                                            sair = true;
                                            break;
                                        default:
                                            break;
                                    }
                                    
                                    
                                } while (sair == false);
                                
                            }
                        }
                        break;   
                          
                    
                }
            }while (verificandoCadastro == true && sair == false);

        } //fim da funcao
    }
            
}
