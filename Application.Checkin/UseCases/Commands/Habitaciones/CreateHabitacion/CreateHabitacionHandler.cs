using Domain.Estadia.Model.Habitacion;
using Domain.Estadia.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.UseCases.Commands.Habitaciones.CreateHabitacion
{
    internal class CreateHabitacionHandler : IRequestHandler<CreateHabitacionCommand,Guid>
    {
        private readonly IHabitacionRepository _habitacionRepository;
        private readonly IUnitOfWork _unitOfWork;
        public CreateHabitacionHandler(IHabitacionRepository habitacionRepository, IUnitOfWork unitOfWork)
        {
            _habitacionRepository = habitacionRepository;
            _unitOfWork = unitOfWork;
        }

       public async Task<Guid> Handle(CreateHabitacionCommand request, CancellationToken cancellationToken)
        {
            Habitacion obj = new Habitacion(request.CodigoHabitacion, request.LimitePersona, request.TipoHabitacion, request.PrecioHabitacion, request.NumeroHabitacion, request.CaracteristicasHabitacion, request.Disponibilidad);

            await _habitacionRepository.CreateAsync(obj);

            await _unitOfWork.Commit();

            return obj.Id;
        }
    }
}
