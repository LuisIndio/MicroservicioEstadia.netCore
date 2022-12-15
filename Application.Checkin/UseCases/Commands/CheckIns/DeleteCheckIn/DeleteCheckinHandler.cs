using Application.Estadia.UseCases.Commands.Habitaciones.DeleteHabitacion;
using Domain.Estadia.Factories;
using Domain.Estadia.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.UseCases.Commands.CheckIns.DeleteCheckIn
{
    internal class DeleteCheckinHandler : IRequestHandler<DeleteCheckinCommand, Guid>
    {
        private readonly ICheckInRepository _checkinrepository;
        private readonly ICheckInFactory _checkinFactory;
        private readonly IUnitOfWork _unitOfWor;

        public DeleteCheckinHandler(ICheckInRepository checkinRepository, ICheckInFactory checkinFactory, IUnitOfWork unitOfWork)
        {
            _checkinrepository = checkinRepository;
            _checkinFactory = checkinFactory;
            _unitOfWor = unitOfWork;

        }
        public async Task<Guid> Handle(DeleteCheckinCommand request, CancellationToken cancellationToken)
        {

            //var reserva = _reservaFactory.CrearReserva(request.HabitacionId);
            //reserva.agregar(request.Tracking,request.Estadia, request.Cliente);

            Guid checkinId = request.checkin;
            await _checkinrepository.DeleteAsync(checkinId);

            await _unitOfWor.Commit();

            return checkinId;
        }
    }
}
