using Application.Estadia.Dto;
using Domain.Estadia.Model.CreditCards;
using Domain.Estadia.Model.Huespedes;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.UseCases.Commands.CheckIns.CreateCheckIn
{
    public class CreateCheckinCommand : IRequest<Guid>
    {
        public Guid ReservaId { get; set; }

        public CreditCardDto CreditCard { get; set; }

        public Guid HabitacionId { get; set; }

        public HuespedDto Huesped { get; set; }

        public Guid ClienteId { get; set; }

    }
}
