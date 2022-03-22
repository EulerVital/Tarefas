using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarefas.Domain
{
    public class PageFilter
    {
        /// <summary>
        /// Total de linhas que deseja
        /// </summary>
        public int RowTotal { get; set; } = 5;

        /// <summary>
        /// Pagina atual
        /// </summary>
        public int Page { get; set; } = 1;

        /// <summary>
        /// Retorna calculo Skip, quantas paginas deve pular
        /// </summary>
        /// <returns></returns>
        public int RetornaCalc()
            => RowTotal * (Page - 1);
    }
}
