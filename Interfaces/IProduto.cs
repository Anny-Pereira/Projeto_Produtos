using Projeto_Produtos_0706.Classes;
using System.Collections.Generic;

namespace Projeto_Produtos_0706.Interfaces
{
    public interface IProduto
    {
        public string Cadastrar(Produto produto);

        public List<Produto> Listar();

        public string Deletar(Produto Produto);
                
    }
}