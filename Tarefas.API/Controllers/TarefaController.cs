using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarefas.API.Helps;
using Tarefas.Domain;
using Tarefas.Interface.Repositories;
using Tarefas.Repository.Common;

namespace Tarefas.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : AppBaseController
    {
        public TarefaController(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }

        /// <summary>
        /// Teste tarefa get
        /// </summary>
        /// <param name="page">Filtro page</param>
        /// <returns></returns>
        [HttpGet]
        public ReturnListObject<Tarefa> Get([FromQuery] PageFilter page)
        {
            var rep = (ITarefaRepository)_serviceProvider.GetService(typeof(ITarefaRepository));
            return rep.Get(page ?? new PageFilter());
        }

        [HttpGet]
        [Route("/async")]
        public async Task<ReturnListObject<Tarefa>> GetAsync([FromQuery] PageFilter page)
        {
            var rep = (ITarefaRepository)_serviceProvider.GetService(typeof(ITarefaRepository));
            return await rep.GetAsync(page ?? new PageFilter());
        }

        [HttpGet]
        [Route("/search/{text}")]
        public ReturnListObject<Tarefa> GetSearch(string text, [FromQuery] PageFilter page)
        {
            var rep = (ITarefaRepository)_serviceProvider.GetService(typeof(ITarefaRepository));
            return rep.GetSearch(text, page ?? new PageFilter());
        }

        [HttpGet]
        [Route("/search-async/{text}")]
        public async Task<ReturnListObject<Tarefa>> GetSearchAsync(string text, [FromQuery] PageFilter page)
        {
            var rep = (ITarefaRepository)_serviceProvider.GetService(typeof(ITarefaRepository));
            return await rep.GetSearchAsync(text, page ?? new PageFilter());
        }

        [HttpGet]
        [Route("/detail/{id}")]
        public Tarefa GetDetail(int? id)
        {
            if (!((id ?? 0) > 0))
                return null;

            var rep = (ITarefaRepository)_serviceProvider.GetService(typeof(ITarefaRepository));
            return rep.GetDetail(id.Value);
        }

        [HttpGet]
        [Route("/detail-async/{id}")]
        public async Task<Tarefa> GetDetailAsync(int? id)
        {
            if (!((id ?? 0) > 0))
                return null;

            var rep = (ITarefaRepository)_serviceProvider.GetService(typeof(ITarefaRepository));
            return await rep.GetDetailAsync(id.Value);
        }
    }
}
