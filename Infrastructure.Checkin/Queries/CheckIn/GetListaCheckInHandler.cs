using Application.Estadia.Dto;
using Application.Estadia.UseCases.Queries.CheckIn;
using Infrastructure.Estadia.EF.Context;
using Infrastructure.Estadia.EF.ReadModel;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.Queries.CheckIn
{
    internal class GetListaCheckInHandler : IRequestHandler<GetListaCheckinQuery, IEnumerable<CheckinDto>>
    {
        private readonly DbSet<CheckinReadModel> checkin;

        public GetListaCheckInHandler(ReadDbContext dbContext)
        {
            checkin = dbContext.Checkin;
        }


        public async Task<IEnumerable<CheckinDto>> Handle(GetListaCheckinQuery request, CancellationToken cancellationToken)
        {
            var query = checkin.AsNoTracking().AsQueryable();

            if (!string.IsNullOrEmpty(request.CheckinSearchTerm))
            {
                query = query.Where(x => x.Id.Equals(request.CheckinSearchTerm));
            }

            var lista = await query.Select(x => new CheckinDto
            {
                CheckinId = x.Id,
                ReservaId = x.ReservaId,
                CreditCardId = x.CreditCardId,
                HabitacionId = x.HabitacionId,
                ClienteId = x.ClienteId
            }).ToListAsync();

            return lista;
        }
    }
}