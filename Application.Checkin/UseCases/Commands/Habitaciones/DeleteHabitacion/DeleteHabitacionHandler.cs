using Domain.Estadia.Factories;
using Domain.Estadia.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.UseCases.Commands.Habitaciones.DeleteHabitacion
{
    internal class DeleteHabitacionHandler : IRequestHandler<DeleteHabitacionCommand, Guid>
    {
        private readonly IHabitacionRepository _habitacionrepository;
        private readonly IHabitacionFactory _habitacionFactory;
        private readonly IUnitOfWork _unitOfWor;

        public DeleteHabitacionHandler(IHabitacionRepository habitacionRepository, IHabitacionFactory habitacionFactory, IUnitOfWork unitOfWork)
        {
            _habitacionrepository = habitacionRepository;
            _habitacionFactory = habitacionFactory;
            _unitOfWor = unitOfWork;

        }
        public async Task<Guid> Handle(DeleteHabitacionCommand request, CancellationToken cancellationToken)
        {

            //var reserva = _reservaFactory.CrearReserva(request.HabitacionId);
            //reserva.agregar(request.Tracking,request.Estadia, request.Cliente);

            Guid habitacionId = request.habitacion;
            await _habitacionrepository.DeleteAsync(habitacionId);

            await _unitOfWor.Commit();

            return habitacionId;
        }
    }
}
