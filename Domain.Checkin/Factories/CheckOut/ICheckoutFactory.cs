using Domain.Estadia.Model.CheckOut;
using Domain.Estadia.Model.Facturas;
using Domain.Estadia.Model.Pagos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Estadia.Factories
{
    public interface ICheckoutFactory
    {
        Checkout CrearCheckOut();
        Checkout CrearCheckOut(Guid ClienteId, Guid CreditCardId, Facturass Factura, Pagoss Pago, Guid CheckInId);
    }
}
