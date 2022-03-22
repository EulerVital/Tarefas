using System.Collections.Generic;

namespace Tarefas.Repository.Common
{
    public class ReturnListObject<T>
    {
        public int TotalPages { get; set; }
        public IEnumerable<T> List { get; set; }
    }
}
