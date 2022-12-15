using Domain.Estadia.Model.CheckIn;
using Domain.Estadia.Repositories;
using Infrastructure.Estadia.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.EF.Repository
{
    internal class CheckinRepository : ICheckInRepository
    {
        private readonly WriteDbContext _context;
        public CheckinRepository(WriteDbContext context)
        {
            _context = context;
        }


        public async Task CreateAsync(Checkin obj)
        {
            await _context.Checkin.AddAsync(obj);
        }

        public async Task DeleteAsync(Guid checkinId)
        {
            var checkin = _context.Checkin.Find(checkinId);
            _context.Remove(checkin);
            await _context.SaveChangesAsync();
        }

        public Task<Checkin> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Checkin obj)
        {
            throw new NotImplementedException();
        }
    }
}