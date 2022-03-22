using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefas.Domain;
using Tarefas.Repository.Common;

namespace Tarefas.Interface.Repositories
{
    public interface ITarefaRepository
    {
        public ReturnListObject<Tarefa> Get(PageFilter page);
        public Task<ReturnListObject<Tarefa>> GetAsync(PageFilter page);
        public ReturnListObject<Tarefa> GetSearch(string text, PageFilter page);
        public Task<ReturnListObject<Tarefa>> GetSearchAsync(string text, PageFilter page);
        public Tarefa GetDetail(int id);
        public Task<Tarefa> GetDetailAsync(int id);

    }
}
