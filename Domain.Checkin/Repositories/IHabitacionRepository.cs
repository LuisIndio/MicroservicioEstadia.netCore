using Domain.Estadia.Model.Habitacion;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Repositories
{
    public interface IHabitacionRepository : IRepository<Habitacion,Guid>
    {
        Task CreateAsync(Habitacion obj);
        Task UpdateAsync(Habitacion obj);
        Task DeleteAsync(Guid habitacionid);

    }
}
