using Domain.Estadia.Repositories;
using MediatR;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.UseCases.Commands.CheckIns.UpdateCheckIn
{
    internal class UpdateCheckinHandler : IRequestHandler<UpdateCheckinCommand>
    {
        private readonly ICheckInRepository _checkinRepository;
        private readonly IUnitOfWork _unitOfWork;
        public UpdateCheckinHandler(ICheckInRepository checkinRepository, IUnitOfWork unitOfWork)
        {
            _checkinRepository = checkinRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(UpdateCheckinCommand request, CancellationToken cancellationToken)
        {
            var checkin = await _checkinRepository.FindByIdAsync(request.CheckinId);

            if (checkin == null)
            {
                throw new Exception("Checkin no existe");

            }

            checkin.EditCheckin(request.ReservaId, request.HabitacionId, request.ClienteId);

            await _checkinRepository.UpdateAsync(checkin);

            await _unitOfWork.Commit();

            return Unit.Value;
        }
    }
}

