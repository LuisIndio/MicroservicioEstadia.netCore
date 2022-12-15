using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareKernel.Core
{
    public interface IRepository<T, in TId> where T : AggregateRoot
    {
        Task<T?> FindByIdAsync(TId id);

        Task CreateAsync(T obj);


    }
}
