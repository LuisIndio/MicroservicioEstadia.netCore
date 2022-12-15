using Infrastructure.Estadia.EF.Context;
using MediatR;
using ShareKernel.Core;

namespace Infrastructure.Ventas.EF
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly WriteDbContext _context;
        //private readonly IMediator _mediator;

        public UnitOfWork(WriteDbContext context)
        {
            _context = context;
         //   _mediator = mediator;
        }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
