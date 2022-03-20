using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefas.Domain
{
    public class TarefaRecurso : BaseDomain
    {
        public Tarefa Tarefa { get; set; }
        public int TarefaId { get; set; }
        public Recurso Recurso { get; set; }
        public int RecursoId { get; set; }
        public bool Favorito { get; set; }
    }
}
