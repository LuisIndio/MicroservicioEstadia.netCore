using Domain.Estadia.Model.CheckIn;
using Domain.Estadia.Model.CheckOut;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Repositories
{
    public interface ICheckoutRepository : IRepository<Checkout, Guid>
    {
        Task CreateAsync(Checkout obj);
        Task UpdateAsync(Checkout obj);
        Task DeleteAsync(Guid checkoutId);
    }
}
