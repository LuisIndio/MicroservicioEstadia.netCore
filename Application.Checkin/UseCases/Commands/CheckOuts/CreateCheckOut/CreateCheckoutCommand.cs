using Application.Estadia.Dto;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.UseCases.Commands.CheckOuts.CreateCheckOut
{
    public class CreateCheckoutCommand : IRequest<Guid>
    {
        public Guid ClienteId { get; set; }

        public Guid CreditCardId { get; set; }

        public Guid CheckInId { get; set; }

        public FacturaDto Factura { get; set; }

        public PagoDto Pago { get; set; }
    }
}
