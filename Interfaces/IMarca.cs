using System.Collections.Generic;
using Projeto_Produtos_0706.Classes;

namespace Projeto_Produtos_0706.Interfaces
{
    public interface IMarca
    {
        public string Cadastrar(Marca Marca);

        public List<Marca> Listar();

        public string Deletar(Marca Marca);
    }
}