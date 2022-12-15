using Domain.Estadia.Model.CheckIn;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Repositories
{
    public interface ICheckInRepository : IRepository<Checkin, Guid>
    {
        Task CreateAsync(Checkin obj);
        Task UpdateAsync(Checkin obj);
        Task DeleteAsync(Guid checkinId);
    }
}
