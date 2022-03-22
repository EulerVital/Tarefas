using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefas.Domain;
using Tarefas.Interface.Repositories;
using Tarefas.Repository.Common;

namespace Tarefas.Repository.Repositories
{
    public class TarefaRepository : BaseRepository<Tarefa>, ITarefaRepository
    {
        public TarefaRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

        public ReturnListObject<Tarefa> Get(PageFilter page)
        {
            var tarefas = DbContext.Tarefas
                .Where(t => t.Excluido == false)
                .Skip(page.RetornaCalc())
                .Take(page.RowTotal)
                .OrderBy(t=>t.Nome);

            return CreatorReturnObject(tarefas);
        }

        //Apenas para fins didaticos
        public dynamic GetSelect(PageFilter page)
        {
            //Exite também o SelectMany

            var tarefas = DbContext.Tarefas
                .Include(t => t.Categoria)
                .Include(t => t.Usuario)
                .Where(t => t.Excluido == false)
                .Select(t => new
                {
                    t.Id
                    ,
                    t.Nome
                    ,
                    t.Descricao
                    ,
                    t.CriadoEm
                    ,
                    Categoria = new
                    {
                        t.Id,
                        t.Categoria.Nome
                    },
                    Usuario = new
                    {
                        t.Usuario.Id
                        ,
                        t.Usuario.Nome
                    }
                })
                .Skip(page.RetornaCalc())
                .Take(page.RowTotal)
                .OrderBy(t => t.Nome);

            return new { TotalPages = tarefas.Count(), List = tarefas.ToList() };
        }

        public async Task<ReturnListObject<Tarefa>> GetAsync(PageFilter page)
        {
            var tarefas = DbContext.Tarefas
                .Where(t => t.Excluido == false)
                .Skip(page.RetornaCalc())
                .Take(page.RowTotal)
                .OrderBy(t => t.Nome);

            return await CreatorReturnObjectAsync(tarefas);
        }

        
        public ReturnListObject<Tarefa> GetSearch(string text, PageFilter page)
        {
            var tarefas = DbContext.Tarefas
                .Where(t => t.Excluido == false && (t.Nome.ToUpper().Contains(text) || t.Descricao.ToUpper().Contains(text)))
                .Skip(page.RetornaCalc())
                .Take(page.RowTotal)
                .OrderBy(t => t.Nome);

            return CreatorReturnObject(tarefas);
        }

        public async Task<ReturnListObject<Tarefa>> GetSearchAsync(string text, PageFilter page)
        {
            var tarefas = DbContext.Tarefas
                .Where(t => t.Excluido == false && (t.Nome.ToUpper().Contains(text) || t.Descricao.ToUpper().Contains(text)))
                .Skip(page.RetornaCalc())
                .Take(page.RowTotal)
                .OrderBy(t => t.Nome);

            return await CreatorReturnObjectAsync(tarefas);
        }

        public Tarefa GetDetail(int id)
        {
            return DbContext.Tarefas
                .Include(t => t.Categoria)
                .Include(t => t.Usuario)
                .Where(t => t.Id == id).FirstOrDefault();
        }

        public async Task<Tarefa> GetDetailAsync(int id)
        {
            return await DbContext.Tarefas
                .Include(t => t.Categoria)
                .Include(t => t.Usuario)
                .Where(t => t.Id == id).FirstOrDefaultAsync();
        }
    }
}
