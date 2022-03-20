using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarefas.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : AppBaseController
    {
        public TarefaController(IServiceProvider serviceProvider) : base(serviceProvider)
        {

        }
    }
}
