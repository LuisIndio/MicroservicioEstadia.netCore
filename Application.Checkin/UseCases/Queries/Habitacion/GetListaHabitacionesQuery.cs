using Application.Estadia.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.UseCases.Queries.Habitacion
{
    public class GetListaHabitacionesQuery : IRequest<IEnumerable<HabitacionDto>>
    {
        public string CodigoSearchTerm { get; set; }

    }
}
