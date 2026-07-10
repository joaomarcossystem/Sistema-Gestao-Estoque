using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestaoEstoqueGemini.Models
{
    public class Produto : EntidadeBase
    {
        public String Nome { get; private set; }
        public Decimal Preco { get; private set; }
        public int QuantidadeEstoque { get; private set; }
        public int CategoriaId { get; private set; }


    }
}
