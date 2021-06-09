using Projeto_Produtos_0706.Classes;
using System.Collections.Generic;

namespace Projeto_Produtos_0706.Interfaces
{
    public interface IProduto
    {
        public string Cadastrar(Produto produto, List<Marca> listaMarcas, int IDproduto);

        public void Listar();

        public string Deletar(Produto Produto);
                
    }
}