using Domain.Estadia.events;
using Domain.Estadia.Model.Facturas;
using Domain.Estadia.Model.Pagos;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Model.CheckOut
{
    public class Checkout : AggregateRoot
    {
        public Guid ClienteId { get; set; }

        public Guid CreditCardId { get; set; }

        public Guid CheckInId { get; set; }

        public Facturass Factura { get; set; }

        public Pagoss Pago { get; set; }

        public Checkout(Guid clienteId, Guid creditCardId, Guid checkInId)
        {
            Id = Guid.NewGuid();
            ClienteId = clienteId;
            CreditCardId = creditCardId;
            CheckInId = checkInId;
        }
        public void Editcheckout(Guid clienteId, Guid creditCardId, Guid checkInId)
        {
            ClienteId = clienteId;
            CreditCardId = creditCardId;
            CheckInId = checkInId;
        }
        public void agregarFactura(string detalleFactura, int numeroFactura, double total, string fecha)
        {
            Factura = new Facturass(detalleFactura, numeroFactura, total, fecha);
            var evento = new FacturaAgregado(detalleFactura, numeroFactura, total, fecha);
            AddDomainEvent(evento);
        }
        public void agregarPago(double total)
        {
            Pago = new Pagoss(total);
            var evento = new PagoAgregado(total);
            AddDomainEvent(evento);
        }

        // Only for Entity Framework
        public Checkout() { }
    }
}
