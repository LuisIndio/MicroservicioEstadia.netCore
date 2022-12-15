using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.events
{
    public record class PagoAgregado : DomainEvent
    {
        public double? Total { get; set; }

        public PagoAgregado(double total) : base(DateTime.Now)
        {
            Total = total;
        }
    }
}
