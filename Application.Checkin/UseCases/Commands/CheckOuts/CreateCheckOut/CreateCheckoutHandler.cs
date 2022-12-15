using Application.Estadia.UseCases.Commands.CheckIns.CreateCheckIn;
using Domain.Estadia.Factories;
using Domain.Estadia.Model.CheckIn;
using Domain.Estadia.Model.CheckOut;
using Domain.Estadia.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.UseCases.Commands.CheckOuts.CreateCheckOut
{
    internal class CreateCheckoutHandler : IRequestHandler<CreateCheckoutCommand, Guid>
    {
        private readonly ICheckoutRepository _checkoutrepository;
        private readonly ICheckInRepository _checkinrepository;

        private readonly ICheckoutFactory _checkoutFactory;

        private readonly IUnitOfWork _unitOfWor;

        public CreateCheckoutHandler(ICheckoutRepository checkoutrepository, ICheckInRepository checkinrepository, ICheckoutFactory checkoutFactory, IUnitOfWork unitOfWork)
        {
            _checkoutrepository = checkoutrepository;
            _checkinrepository = checkinrepository;
            _checkoutFactory = checkoutFactory;

            _unitOfWor = unitOfWork;

        }
        public async Task<Guid> Handle(CreateCheckoutCommand request, CancellationToken cancellationToken)
        {
            Guid ClienteId = request.ClienteId;

            Guid CreditCardId = request.CreditCardId;

            //CreditCard creditcard = new CreditCard(request.CreditCard.TipoTarjeta, request.CreditCard.NumeroTarjeta);

            Guid CheckInId = request.CheckInId;

            Checkout obj = new Checkout(ClienteId, CreditCardId, CheckInId);

            obj.agregarFactura(request.Factura.DetalleFactura, request.Factura.NumeroFactura,request.Factura.Total,request.Factura.Fecha);

            obj.agregarPago(request.Pago.Total);

            //var obj = _reservaFactory.CrearReserva(tracking, TipoHabitacionId, estadia, cliente);
            //obj.agregarCreditCard(request.CreditCard.TipoTarjeta, request.CreditCard.NumeroTarjeta);
            await _checkoutrepository.CreateAsync(obj);
            
            await _unitOfWor.Commit();
            await _checkinrepository.DeleteAsync(CheckInId);

            //obj.enviarCorreo(tracking, cliente);

            return obj.Id;
        }
    }
}
