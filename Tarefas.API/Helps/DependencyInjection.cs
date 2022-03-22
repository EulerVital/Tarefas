using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarefas.Interface.Repositories;
using Tarefas.Repository.Repositories;

namespace Tarefas.API.Helps
{
    public class DependencyInjection
    {
        public static void Register(IServiceCollection svc)
        {
            RepositoryDependences(svc);
        }

        private static void RepositoryDependences(IServiceCollection svc)
        {
            svc.AddScoped<ITarefaRepository, TarefaRepository>();
        }
    }
}
