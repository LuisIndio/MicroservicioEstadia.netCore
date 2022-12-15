using Domain.Estadia.ValueObjects;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Model.Facturas
{
    public class Facturass : Entity
    {
        public string? DetalleFactura { get; set; }

        public int NumeroFactura { get; set; }

        public PrecioValue Total { get; set; }

        public string? Fecha { get; set; }

        public Facturass(string detalleFactura, int numeroFactura, double total, string fecha) : base()
        {
            Id = Guid.NewGuid();
            DetalleFactura = detalleFactura;
            NumeroFactura = numeroFactura;
            Total = total;
            Fecha = fecha;
        }
        public Facturass() { }
    }
}
