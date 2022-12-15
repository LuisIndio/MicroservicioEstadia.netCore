using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.events
{
    public record class FacturaAgregado : DomainEvent
    {
        public string? DetalleFactura { get; set; }

        public int NumeroFactura { get; set; }

        public double Total { get; set; }

        public string? Fecha { get; set; }

        public FacturaAgregado(string detalleFactura, int numeroFactura, double total, string fecha) : base(DateTime.Now)
        {
            DetalleFactura = detalleFactura;
            NumeroFactura = numeroFactura;
            Total = total;
            Fecha = fecha;
        }
    }
}
