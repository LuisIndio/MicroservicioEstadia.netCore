using Domain.Estadia.Model.CheckIn;
using Domain.Estadia.Model.CheckOut;
using Domain.Estadia.Repositories;
using Infrastructure.Estadia.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.EF.Repository
{
    internal class CheckoutRepository : ICheckoutRepository
    {
        private readonly WriteDbContext _context;
        public CheckoutRepository(WriteDbContext context)
        {
            _context = context;
        }


        public async Task CreateAsync(Checkout obj)
        {
            await _context.Checkout.AddAsync(obj);
        }

        public async Task DeleteAsync(Guid checkoutId)
        {
            var checkout = _context.Checkout.Find(checkoutId);
            _context.Remove(checkout);
            await _context.SaveChangesAsync();
        }

        public Task<Checkout> FindByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Checkout obj)
        {
            throw new NotImplementedException();
        }
    }
}

