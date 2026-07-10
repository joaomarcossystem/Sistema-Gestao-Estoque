using SistemaGestaoEstoqueGemini.Interfaces;
using SistemaGestaoEstoqueGemini.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestaoEstoqueGemini.Repositories
{
    public class ProdutoRepository : IRepository<Produto>
    {
        public void Adicionar(Produto classe)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Produto classe)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Produto> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
