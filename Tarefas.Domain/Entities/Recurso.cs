using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefas.Domain.Enums;

namespace Tarefas.Domain
{
    public class Recurso : BaseDomain 
    {
        public string Nome { get; set; }
        public EnumRecursos Recursos { get; set; }
        public string Descricao { get; set; }
    }
}
