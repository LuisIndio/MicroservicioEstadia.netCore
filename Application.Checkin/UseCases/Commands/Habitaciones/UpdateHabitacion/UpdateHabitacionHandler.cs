using Application.Estadia.UseCases.Commands.CheckIns.UpdateCheckIn;
using Domain.Estadia.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.UseCases.Commands.Habitaciones.UpdateHabitacion
{
    internal class UpdateHabitacionHandler : IRequestHandler<UpdateHabitacionCommand>
    {
        private readonly IHabitacionRepository _habitacionRepository;
        private readonly IUnitOfWork _unitOfWork;
        public UpdateHabitacionHandler(IHabitacionRepository habitacionRepository, IUnitOfWork unitOfWork)
        {
            _habitacionRepository = habitacionRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateHabitacionCommand request, CancellationToken cancellationToken)
        {
            var habitacion = await _habitacionRepository.FindByIdAsync(request.HabitacionId);

            if (habitacion == null)
            {
                throw new Exception("Habitacion no existe");

            }

            habitacion.EditHabitacion(request.CodigoHabitacion, request.LimitePersona, request.TipoHabitacion, request.PrecioHabitacion, request.NumeroHabitacion, request.CaracteristicasHabitacion, request.Disponibilidad);

            await _habitacionRepository.UpdateAsync(habitacion);

            await _unitOfWork.Commit();

            return Unit.Value;
        }
    }
}

