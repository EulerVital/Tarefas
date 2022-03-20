using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefas.Domain
{
    public class Tarefa : BaseDomain
    {
        public string Nome { get; set; }
        public virtual Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
        public string Descricao { get; set; }
    }
}
