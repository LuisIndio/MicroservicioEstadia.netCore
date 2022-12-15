using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.events
{
    public record class CreditCardAgregado : DomainEvent
    {
        public string? TipoTarjeta { get; set; }

        public string? NumeroTarjeta { get; set; }

        public CreditCardAgregado(string tipoTarjeta, string numeroTarjeta) : base(DateTime.Now)
        {
            TipoTarjeta = tipoTarjeta;
            NumeroTarjeta = numeroTarjeta;
        }
    }
}
