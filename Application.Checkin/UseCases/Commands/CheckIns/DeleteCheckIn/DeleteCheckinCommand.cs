using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.UseCases.Commands.CheckIns.DeleteCheckIn
{
    public class DeleteCheckinCommand : IRequest<Guid>
    {
        //public ICollection<Cliente> clientes { get; set; }
        //public Cliente clientes { get; set; }
        public Guid checkin { get; set; }


    }
}
