using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaGestaoEstoqueGemini.Models
{
    public abstract class EntidadeBase
    {

        public int Id { get; private set; }
        public DateTime DataCadastro { get; private set; }

        
    }
}
