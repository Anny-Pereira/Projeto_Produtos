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

        public string Cadastrar(Marca Marca)
        {
            throw new NotImplementedException();
        }

        public string Deletar(Marca Marca)
        {
            throw new NotImplementedException();
        }

        public List<Marca> Listar()
        {
            throw new NotImplementedException();
        }
    }
}