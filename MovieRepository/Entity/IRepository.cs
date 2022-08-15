using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRepository.Entity
{
    public interface IRepository<T> where T : class
    {
        Task CreateAsync(T entity);
    }
}
