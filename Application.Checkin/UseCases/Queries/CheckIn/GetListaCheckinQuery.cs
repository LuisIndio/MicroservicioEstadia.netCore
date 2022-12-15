using Application.Estadia.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.UseCases.Queries.CheckIn
{
    public class GetListaCheckinQuery : IRequest<IEnumerable<CheckinDto>>
    {
        public string CheckinSearchTerm { get; set; }

    }
}
