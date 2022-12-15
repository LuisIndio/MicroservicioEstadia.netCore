using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Estadia.Dto
{
    public class FacturaDto
    {
        public Guid FacturaId { get; set; }

        public string? DetalleFactura { get; set; }

        public int NumeroFactura { get; set; }

        public double Total { get; set; }

        public string? Fecha { get; set; }
    }
}
