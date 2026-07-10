using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestaoEstoqueGemini.Models
{
    public class Categoria : EntidadeBase
    {
        public String Nome { get; private set; }
        public String Descricao { get; private set; }

    }
}
