using Domain.Estadia.Factories;
using Domain.Estadia.Model.CheckIn;
using Domain.Estadia.Model.CreditCards;
using Domain.Estadia.Model.Habitacion;
using Domain.Estadia.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.UseCases.Commands.CheckIns.CreateCheckIn
{
    internal class CreateCheckinHandler : IRequestHandler<CreateCheckinCommand, Guid>
    {
        private readonly ICheckInRepository _checkinrepository;
        private readonly IHabitacionRepository _habitacionrepository;

        private readonly ICheckInFactory _checkinFactory;
        private readonly IUnitOfWork _unitOfWor;

        public CreateCheckinHandler(ICheckInRepository checkinrepository, IHabitacionRepository habitacionrepository,  ICheckInFactory checkinFactory, IUnitOfWork unitOfWork)
        {
            _checkinrepository = checkinrepository;
            _habitacionrepository = habitacionrepository;

            _checkinFactory = checkinFactory;
            _unitOfWor = unitOfWork;

        }
        public async Task<Guid> Handle(CreateCheckinCommand request, CancellationToken cancellationToken)
        {
            Guid ReservaId = request.ReservaId;

            Guid HabitacionId = request.HabitacionId;

            //CreditCard creditcard = new CreditCard(request.CreditCard.TipoTarjeta, request.CreditCard.NumeroTarjeta);

            Guid ClienteId = request.ClienteId;

            Checkin obj = new Checkin(ReservaId, HabitacionId, ClienteId);
            Habitacion habi = await _habitacionrepository.FindByIdAsync(obj.HabitacionId);
            
            habi.CambiarDisponibilidad();

            obj.agregarCreditCard(request.CreditCard.TipoTarjeta, request.CreditCard.NumeroTarjeta);

            obj.agregarHuesped(request.Huesped.Dni);

            //var obj = _reservaFactory.CrearReserva(tracking, TipoHabitacionId, estadia, cliente);
            //obj.agregarCreditCard(request.CreditCard.TipoTarjeta, request.CreditCard.NumeroTarjeta);
            await _checkinrepository.CreateAsync(obj);
            await _unitOfWor.Commit();
            await _habitacionrepository.UpdateAsync(habi);


            //obj.enviarCorreo(tracking, cliente);

            return obj.Id;
        }
    }
}
