using Application.Estadia.Dto;
using Application.Estadia.UseCases.Queries.Habitacion;
using Infrastructure.Estadia.EF.Context;
using Infrastructure.Estadia.EF.ReadModel;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Estadia.Queries.Habitacion
{
    internal class GetListaHabitacionesHandler : IRequestHandler<GetListaHabitacionesQuery, IEnumerable<HabitacionDto>>
    {
        private readonly DbSet<HabitacionReadModel> habitacion;

        public GetListaHabitacionesHandler(ReadDbContext dbContext)
        {
            habitacion = dbContext.Habitacion;
        }


        public async Task<IEnumerable<HabitacionDto>> Handle(GetListaHabitacionesQuery request, CancellationToken cancellationToken)
        {
            var query = habitacion.AsNoTracking().AsQueryable();

            if (!string.IsNullOrEmpty(request.CodigoSearchTerm))
            {
                query = query.Where(x => x.CodigoHabitacion.Contains(request.CodigoSearchTerm.ToLower()));
            }

            var lista = await query.Select(x => new HabitacionDto
            {
                HabitacionId = x.Id,
                CodigoHabitacion = x.CodigoHabitacion,
                TipoHabitacion = x.TipoHabitacion,
                LimitePersona = x.LimitePersona,
                PrecioHabitacion = x.PrecioHabitacion,
                NumeroHabitacion = x.NumeroHabitacion,
                CaracteristicasHabitacion = x.CaracteristicasHabitacion,
                Disponibilidad = x.Disponibilidad
            }).ToListAsync();

            return lista;
        }
    }
}
