using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.events
{
    public record class HuespedAgregado : DomainEvent
    {
        public string Dni { get; set; }

        public HuespedAgregado(string dni) : base(DateTime.Now)
        {
            Dni = dni;
        }
    }
}
