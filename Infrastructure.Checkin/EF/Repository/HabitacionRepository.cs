using Domain.Estadia.Model.Habitacion;
using Domain.Estadia.Repositories;
using Infrastructure.Estadia.EF.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.EF.Repository
{
    internal class HabitacionRepository : IHabitacionRepository
    {
        private readonly WriteDbContext _context;

        public HabitacionRepository(WriteDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(Habitacion obj)
        {
            await _context.Habitacion.AddAsync(obj);
        }

        public async Task DeleteAsync(Guid habitaciond)
        {
            var habitacion = _context.Habitacion.Find(habitaciond);
            _context.Remove(habitacion);
            await _context.SaveChangesAsync();
        }

        public async Task<Habitacion?> FindByIdAsync(Guid id)
        {
            return await _context.Habitacion.FirstOrDefaultAsync(x => x.Id == id);
        }

        public Task UpdateAsync(Habitacion obj)
        {
            _context.Habitacion.Update(obj);
            return Task.CompletedTask;
        }
    }
}
