using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefas.Repository.Common;

namespace Tarefas.Repository.Repositories
{
    public abstract class BaseRepository<T>
    {
        protected readonly ApplicationDbContext DbContext;

        public BaseRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        /// <summary>
        /// Cria e retorna objeto com a listagem e o total de paginas
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static ReturnListObject<T> CreatorReturnObject(IQueryable<T> list)
        {
            try
            {
                if (list == null)
                    throw new Exception("Paramater list is not null");

                return new ReturnListObject<T>()
                {
                    List = list.ToList(),
                    TotalPages = list.Count()
                };
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Cria e retorna objeto com a listagem e o total de paginas de forma assincrona
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static async Task<ReturnListObject<T>> CreatorReturnObjectAsync(IQueryable<T> list)
        {
            try
            {
                if (list == null)
                    throw new Exception("Paramater list is not null");

                return new ReturnListObject<T>()
                {
                    List = await list.ToListAsync(),
                    TotalPages = await list.CountAsync()
                };
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
