using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestaoEstoqueGemini.Interfaces
{
    public interface IRepository <T>
    {
        public void Adicionar(T classe);
        public List<T> ObterTodos();
        public List<T> ObterPorId(int id);
        public void Atualizar(T classe);
        public void Deletar(int id);
    }
}
