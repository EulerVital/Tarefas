using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefas.Domain
{
    public class Categoria : BaseDomain
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
